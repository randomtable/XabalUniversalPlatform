
Partial Class Result
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.ContentType = "text/html; charset=utf-8"
        Label1.Text = Session.Item("Result")
        Session.Clear()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Session.Clear()
        Response.Redirect("Default.aspx")
    End Sub
End Class
