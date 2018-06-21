Option Strict On
Imports System.Web.Services

<WebService(Namespace:="http://acgltd.co.uk", Description:="Welcome to the Accident Credit Group 'Add Extended Case' Web Service.<br /><br />If you have any questions please contact Ed Sansbury.")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class AddExtendedCase : Inherits System.Web.Services.WebService

    <WebMethod(Description:="Click the link above to see the Web Service")>
    Public Function ACGAddExtendedCase(ByVal CaseData As String) As String
        Dim strResult As String = String.Empty

        Using ws As New wsAddExtendedCase.AddExtendedCase
            strResult = ws.ACGAddExtendedCase(CaseData)
        End Using

        Return strResult
    End Function

End Class