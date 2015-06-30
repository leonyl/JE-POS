Imports Microsoft.VisualBasic
Imports System.Security.Cryptography
Imports System.Text

Public Class Encrypt
    Public Function Encrypt(ByVal Data As String) As String
        Dim shaM As New SHA1Managed
        Convert.ToBase64String(shaM.ComputeHash(Encoding.ASCII.GetBytes(Data)))
        Dim eNC_data() As Byte = ASCIIEncoding.ASCII.GetBytes(Data)
        Dim eNC_str As String = Convert.ToBase64String(eNC_data)
        Encrypt = eNC_str
    End Function

    Public Function Decrypt(ByVal Data As String) As String
        Dim dEC_data() As Byte = Convert.FromBase64String(Data)
        Dim dEC_Str As String = ASCIIEncoding.ASCII.GetString(dEC_data)
        Decrypt = dEC_Str
    End Function
End Class
