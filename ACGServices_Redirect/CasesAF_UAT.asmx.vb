Option Strict On
Imports System.Web.Services

<WebService(Namespace:="http://acgltd.co.uk", Description:="Welcome to the Accident Credit Group 'Cases AF' Web Service.<br /><br />If you have any questions please contact Ed Sansbury.")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class CasesAF_UAT : Inherits System.Web.Services.WebService

    <WebMethod(Description:="Insert an AF Case")>
    Public Function Insert(caseXML As String) As String
        Dim strResult As String = String.Empty

        Using ws As New wsCasesAF_UAT.CasesAF
            strResult = ws.Insert(caseXML)
        End Using

        Return strResult
    End Function

End Class