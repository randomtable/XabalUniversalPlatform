Imports System.Data.Odbc

Partial Class Piattaforma
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim logindata As String = Session.Item("Login")
        Dim login() As String = logindata.Split(";")
        Dim engine As New Xabal.Class1
        Dim username As String = login(0)
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
        Dim password As String = login(1)
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
End Class
