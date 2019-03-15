Imports System.Net
Imports System.IO
Imports System.Data.Odbc

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.ContentType = "text/html; charset=utf-8"
        If Request.Cookies("SameSite") Is Nothing Then
            Response.Cookies.Set(New HttpCookie("SameSite", "Strict"))
        Else
            Response.Cookies.Set(Request.Cookies("SameSite"))
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim engine As New Xabal.Class1
        Dim username As String = sanitize(Replace(TextBox1.Text, "%", ""))
        If engine.CheckNull(username) = "KO" Then
            Session.Item("Result") = "Inserire un nome utente!"
            Response.Redirect("Result.aspx")
        End If
        If engine.CheckMulti("login", "username", "username = '" & username & "'", "xabal") = "OK" Then
            Session.Item("Result") = "Credenziali di accesso errate!"
            Response.Redirect("Result.aspx")
        End If
        If ReadUsername("login", "username", "username = '" & username & "'", "xabal") <> username Then
            Session.Item("Result") = "Credenziali di accesso errate!"
            Response.Redirect("Result.aspx")
        End If
        Dim password As String = sanitize(Replace(TextBox2.Text, "%", ""))
        If engine.CheckNull(password) = "KO" Then
            Session.Item("Result") = "Inserire una password!"
            Response.Redirect("Result.aspx")
        End If
        If engine.CheckMulti("login", "password", "password = '" & password & "'", "xabal") = "OK" Then
            Session.Item("Result") = "Credenziali di accesso errate!"
            Response.Redirect("Result.aspx")
        End If
        If engine.CheckMulti("login", "password", "password = '" & password & "' AND username = '" & username & "'", "xabal") = "OK" Then
            Session.Item("Result") = "Credenziali di accesso errate!"
            Response.Redirect("Result.aspx")
        End If
        If ReadPassword("login", "password", "password = '" & password & "' AND username = '" & username & "'", "xabal") <> password Then
            Session.Item("Result") = "Credenziali di accesso errate!"
            Response.Redirect("Result.aspx")
        End If
        Session.Item("Login") = username & ";" & password
        Response.Redirect("Piattaforma.aspx")
    End Sub

    Public Function ReadUsername(ByVal tabella As String, ByVal campo As String, ByVal where As String, ByVal dsn As String) As String

        Dim queryString As String = "SELECT " & tabella & "." & campo & "  FROM " & tabella & " WHERE " & where & ";"

        Using connection As New OdbcConnection("Dsn=" & dsn)
            Dim command As New OdbcCommand(queryString, connection)

            connection.Open()

            Dim reader As OdbcDataReader = command.ExecuteReader()

            While reader.Read()
                Return reader.GetValue(0)
            End While

            If reader.HasRows = False Then
                Return "OK"
            Else
                Return "KO"
            End If

            connection.Close()
            reader.Close()
        End Using

        Return "Hello World"
    End Function

    Public Function ReadPassword(ByVal tabella As String, ByVal campo As String, ByVal where As String, ByVal dsn As String) As String

        Dim queryString As String = "SELECT " & tabella & "." & campo & "  FROM " & tabella & " WHERE " & where & ";"

        Using connection As New OdbcConnection("Dsn=" & dsn)
            Dim command As New OdbcCommand(queryString, connection)

            connection.Open()

            Dim reader As OdbcDataReader = command.ExecuteReader()

            While reader.Read()
                Return reader.GetValue(0)
            End While

            If reader.HasRows = False Then
                Return "OK"
            Else
                Return "KO"
            End If

            connection.Close()
            reader.Close()
        End Using

        Return "Hello World"
    End Function

    Private Function sanitize(ByVal param As String) As String
        Dim request As WebRequest = WebRequest.Create("https://loremitalia.altervista.org/xwaf.php")
        request.Method = "POST"
        Dim postData As String = "sanitize=" & param
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        Console.WriteLine((CType(response, HttpWebResponse)).StatusDescription)
        dataStream = response.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        dataStream.Close()
        response.Close()
        Return responseFromServer
    End Function
End Class
