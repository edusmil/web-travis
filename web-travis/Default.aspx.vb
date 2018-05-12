Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnTeste_Click(sender As Object, e As EventArgs) Handles btnTeste.Click
        Response.Write("Legal ok!!")
    End Sub
End Class