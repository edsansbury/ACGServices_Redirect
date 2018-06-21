Option Strict On
Imports System.Web.Services

<WebService(Namespace:="http://acgltd.co.uk", Description:="Welcome to the Accident Credit Group 'Update Case' Web Service.<br /><br />If you have any questions please contact Ed Sansbury.")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class UpdateCase : Inherits System.Web.Services.WebService

    <WebMethod(Description:="Click the link above to see the Web Service")>
    Public Function ACGUpdateCase(ByVal CaseData As String) As String
        Dim strResult As String = String.Empty

        Using ws As New wsUpdateCase.UpdateCase
            strResult = ws.ACGUpdateCase(CaseData)
        End Using

        Return strResult
    End Function

End Class