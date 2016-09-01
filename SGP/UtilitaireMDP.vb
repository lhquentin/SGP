'les importations suivantes seraient nécessaires si on n'écrivait pas la version longue des appels aux classes de cryptographie et d'encodage
'Imports System.Security.Cryptography
'Imports System.Text.Encoding

Public Class UtilitaireMDP

    '--------------------------------------------------------------------------------------------------------------
    'voir à l'adresse suivante pour une explication détaillée d'une stratégie adéquate de gestion de mots de passe:
    'https://crackstation.net/hashing-security.htm
    '--------------------------------------------------------------------------------------------------------------

    Const PBKDF2_ITERATIONS = 1000 'nombre d'itéarations pour le key stretching
    Const NB_OCTETS_HASH_SEL = 31 'les hash et les sel auront la même taille (32 octets = 256 bits = format généré par SHA256)

    Public Function GenererSel() As String

        '-------------------------------------------------------------------------------------------------------------------
        'génération ALÉATOIRE du sel, qui doit IMPÉRATIVEMENT être suffisamment long et différent d'un utilisateur à l'autre
        '-------------------------------------------------------------------------------------------------------------------

        Dim csprng As New Security.Cryptography.RNGCryptoServiceProvider()
        Dim sel(NB_OCTETS_HASH_SEL) As Byte
        Dim strSel As String

        'génère le sel et le convertit en string
        csprng.GetBytes(sel)
        strSel = Convert.ToBase64String(sel)

        Return strSel

    End Function

    Public Function GenererHash(motDePasse As String, sel As String) As String

        Dim hashAlg As New Security.Cryptography.SHA256CryptoServiceProvider

        '-----------------------------------------
        'calcule le hash et le convertit en string
        '-----------------------------------------

        'le hash est généré à partir de la concaténation du sel et du mot de passe
        Dim hashvalue() As Byte = hashAlg.ComputeHash(System.Text.Encoding.Default.GetBytes(sel + motDePasse))

        'on pourrait remplacer l'instruction précédente par du key stretching en faisant un appel à PBKDF2()
        'ça diminue les risques si le hacker est très sérieux, mais ça alourdit le traitement sur un serveur web (denial of service, DoS)
        'Dim hashvalue = PBKDF2(motDePasse, sel, PBKDF2_ITERATIONS)

        Return Convert.ToBase64String(hashvalue)

    End Function

    Public Function VerifierMDP(motDePasse As String, sel As String, hashOriginal As String) As Boolean

        '-----------------------------------------------------------------------------------------
        'on doit concaténer le sel et le mot de passe entré, passer ça dans le hachoir et vérifier
        'si ça donne le même résultat que le hash calculé précédemment
        '-----------------------------------------------------------------------------------------

        Dim hashAlg As New Security.Cryptography.SHA256CryptoServiceProvider 'on utilise le hachage SHA256
        Dim nouveauHash As String

        'calcule le hash et le convertit en string
        Dim hashvalue() As Byte = hashAlg.ComputeHash(System.Text.Encoding.Default.GetBytes(sel + motDePasse))

        'encore une fois, on pourrait utiliser le key stretching pour rentre ça encore plus sécure, mais c'est très lourd pour un serveur web...
        'Dim hashvalue() As Byte = PBKDF2(motDePasse, sel, PBKDF2_ITERATIONS)

        nouveauHash = Convert.ToBase64String(hashvalue)

        If nouveauHash = hashOriginal Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function PBKDF2(motDePasse As String, sel As String, iterations As Integer) As Byte()

        'utilisation du key stretching au lieu de SHA256
        'ça rend la résolution de mot de passe encore plus difficile, 
        'mais ça peut provoquer un denial of service (DoS) si un hacker s'attaque à un SERVEUR WEB

        Dim hashAlg As New System.Security.Cryptography.Rfc2898DeriveBytes(motDePasse, Convert.FromBase64String(sel))
        hashAlg.IterationCount = iterations

        Return hashAlg.GetBytes(NB_OCTETS_HASH_SEL)

    End Function

    Public Function GenererChaineDeCaracteres(Optional ByVal length As Integer = 10) As String

        'cette fonction peut être utilisée pour générer aléatoirement un mot de passe
        'IMPORTANT: ne PAS l'utiliser pour générer le sel qu'on doit concaténer au mot de passe avant le hachage!

        Dim strChaine As String = ""
        Dim rand As New Random()

        For i As Integer = 1 To length
            Dim charNo As Integer = rand.Next(1, 62) ' Represents the 26 letters (lower and uppercase) and the 10 digits

            If charNo <= 10 Then ' Digits (1-10) : ASCII[48-57]
                charNo += 47
            ElseIf charNo <= 36 Then ' Uppercase letters (11-36) : ASCII[65-90]
                charNo += 54
            Else ' Lowercase letters (36-62) : ASCII[97-122]
                charNo += 60
            End If

            strChaine &= Chr(charNo)
        Next i

        Return strChaine

    End Function

End Class
