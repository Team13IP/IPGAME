Imports IPGame.ServiceReference1
Imports System.Xml

Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Session.Count = 0) Then
            Session("Logat") = 0
            Session("Username") = "Guest"
            Session("Parola") = "1234"
            Session("Scor") = 0
            Session("Rank") = 0
            Session("Claspg") = 1
        ElseIf Session("Logat") = 1 Then
            Utilizator.Visible = False
            Password.Visible = False
            Button1.Text = "Logout"
            Pw.Visible = False
            Usr.Visible = False
            Log1.Visible = True
            Log1.Text = "Bine ai revenit, <a href=""contulmeu.aspx"" title=""link catre profil"">" + Session("Username") + "</a>!"
            Dim se As New Service1Client
            Dim ra As New RankRequest(Session("Username"))
            Dim re As RankResponse = se.Rank(ra)
            Log2.Text = "Loc ocupat in clasament:" + re.RankResult.ToString
            Log2.Visible = True
            Log3.Visible = True
            Dim se1 As New ServiceReference1.ScorRequest(Session("Username"))
            Dim se2 As ScorResponse = se.Scor(se1)
            Log3.Text = "Numar de Puncte Obtinute:" + se2.ScorResult.ToString
            cont.Visible = False
        End If

        Dim s As New Service1Client()
        Dim res As New ServiceReference1.Top10Request
        Dim resa As New ServiceReference1.Top10Response
        Dim f(10) As ServiceReference1.CompositeType
        resa = s.Top10(res)
        f = resa.Top10Result

        Try
            Cmen112.Text = f(0).SecondValue.ToString
            Cmen113.Text = f(0).ThirdValue.ToString
        Catch ex As Exception
            Cmen112.Text = "-"
            Cmen113.Text = "-"
        End Try
        Try
            Cmen22.Text = f(1).SecondValue.ToString
            Cmen23.Text = f(1).ThirdValue.ToString
        Catch ex As Exception
            Cmen22.Text = "-"
            Cmen23.Text = "-"
        End Try
        Try
            Cmen32.Text = f(2).SecondValue.ToString
            Cmen33.Text = f(2).ThirdValue.ToString
        Catch ex As Exception
            Cmen32.Text = "-"
            Cmen33.Text = "-"
        End Try
        Try
            Cmen42.Text = f(3).SecondValue.ToString
            Cmen43.Text = f(3).ThirdValue.ToString
        Catch ex As Exception
            Cmen42.Text = "-"
            Cmen43.Text = "-"
        End Try
        Try
            Cmen52.Text = f(4).SecondValue.ToString
            Cmen53.Text = f(4).ThirdValue.ToString
        Catch ex As Exception
            Cmen52.Text = "-"
            Cmen53.Text = "-"
        End Try
        Try
            Cmen62.Text = f(5).SecondValue.ToString
            Cmen63.Text = f(5).ThirdValue.ToString
        Catch ex As Exception
            Cmen62.Text = "-"
            Cmen63.Text = "-"
        End Try
        Try
            Cmen72.Text = f(6).SecondValue.ToString
            Cmen73.Text = f(6).ThirdValue.ToString
        Catch ex As Exception
            Cmen72.Text = "-"
            Cmen73.Text = "-"
        End Try
        Try
            Cmen82.Text = f(7).SecondValue.ToString
            Cmen83.Text = f(7).ThirdValue.ToString
        Catch ex As Exception
            Cmen82.Text = "-"
            Cmen83.Text = "-"
        End Try
        Try
            Cmen92.Text = f(8).SecondValue.ToString
            Cmen93.Text = f(8).ThirdValue.ToString
        Catch ex As Exception
            Cmen92.Text = "-"
            Cmen93.Text = "-"
        End Try
        Try
            Cmen102.Text = f(9).SecondValue.ToString
            Cmen103.Text = f(9).ThirdValue.ToString
        Catch ex As Exception
            Cmen102.Text = "-"
            Cmen103.Text = "-"
        End Try
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Session("Adversar") = "TestBot"
        Session("Ebot") = "Robotix"
        Session("Round") = 0
        Session("Textbox") = " "
        Response.Redirect("joaca-pasFinal.aspx")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim se As New ServiceReference1.Service1Client()
        Dim result As Integer
        Dim ser As New ServiceReference1.CheckLoginRequest(Utilizator.Text, Password.Text)
        Dim serv As New ServiceReference1.CheckLoginResponse()
        serv = se.CheckLogin(ser)
        result = serv.CheckLoginResult
        If result = 1 And Session("Logat") = 0 Then
            Utilizator.Visible = False
            Password.Visible = False
            Pw.Visible = False
            Usr.Visible = False
            Session("Username") = Utilizator.Text
            Session("Parola") = Password.Text
            Log1.Visible = True
            Log1.Text = "Bine ai revenit, <a href=""contulmeu.aspx"" title=""link catre profil"">" + Session("Username") + "</a>!"
            Dim ra As New RankRequest(Session("Username"))
            Dim re As RankResponse = se.Rank(ra)
            Log2.Text = "Loc ocupat in clasament:" + re.RankResult.ToString
            Session("Rank") = re.RankResult
            Log2.Visible = True
            Log3.Visible = True
            Dim se1 As New ServiceReference1.ScorRequest(Session("Username"))
            Dim se2 As ScorResponse = se.Scor(se1)
            Log3.Text = "Numar de Puncte Obtinute:" + se2.ScorResult.ToString
            Session("Logat") = 1
            cont.Visible = False
            Button1.Text = "Logout"

        ElseIf Session("Logat") = 1 Then
            Button1.Text = "Login"
            Utilizator.Visible = True
            Password.Visible = True
            Pw.Visible = True
            Usr.Visible = True
            Log1.Visible = False
            Log2.Visible = False
            Log3.Visible = False
            cont.Visible = True
            Session("Logat") = 0
            Session("Username") = "Guest"
            Session("Parola") = "1234"
            Session("Scor") = 0
            Session("Rank") = 0
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Visible = False
        Button5.Enabled = True
        Dim con As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
        con.Open()
        Dim cmdrec As New SqlServerCe.SqlCeCommand("delete from moves where Username='" + Session("Username") + "'", con)
        cmdrec.ExecuteNonQuery()
        Dim cmd As New SqlServerCe.SqlCeCommand("Select Username,Robot,[To] from Matchmaking where Request='Game' and [To] IS NULL", con)
        Dim cmd2 As New SqlServerCe.SqlCeCommand("insert into matchmaking values(NewId(),'Game','" + Session("Username") + "','" + Session("Robot") + "',NULL)", con)
        Dim read As SqlServerCe.SqlCeDataReader
        read = cmd.ExecuteReader()
        Button4.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
        If read.Read() Then
            Session("Adversar") = read.GetString(0)
            Session("Ebot") = read.GetString(1)
            Session("Round") = 0
            Session("Textbox") = " "
            Dim cmd3 As New SqlServerCe.SqlCeCommand("insert into matchmaking values(NewId(),'Join','" + Session("Username") + "','" + Session("Robot") + "','" + Session("Adversar") + "')", con)
            Dim cmd4 As New SqlServerCe.SqlCeCommand("delete from matchmaking where Request='Game' and Username='" + Session("Adversar") + "'", con)

            cmd4.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            Session("Begin") = 2
            Response.Redirect("joaca-pasFinal.aspx")
        Else
            cmd2.ExecuteNonQuery()
            Timer1.Enabled = True
            Session("Time") = 0
        End If



    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim cen As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
        cen.Open()
         Dim cmd6 As New SqlServerCe.SqlCeCommand("Select Username,Robot,[To] from Matchmaking where Request='Join' and [to]='" + Session("Username") + "'", cen)
        Dim cmd4 As New SqlServerCe.SqlCeCommand("delete from matchmaking where Request='Game' and Username='" + Session("Username") + "'", cen)

        Dim r As SqlServerCe.SqlCeDataReader
        r = cmd6.ExecuteReader()
        If Session("Time") = 20 Then
            cmd4.ExecuteNonQuery()
            Label2.Visible = True
            Timer1.Enabled = False
            Button5.Enabled = False
            Session("Time") = 0
        End If
        If r.Read() Then
            Session("Adversar") = r.GetString(0)
            Session("Ebot") = r.GetString(1)
            Session("Round") = 0
            Session("Textbox") = " "
            Dim cmd5 As New SqlServerCe.SqlCeCommand("delete from matchmaking where Request='Join' and Username='" + Session("Adversar") + "'", cen)
            Session("Begin") = 1
            cmd5.ExecuteNonQuery()
            Response.Redirect("joaca-pasFinal.aspx")
        Else
            Session("Time") = Session("Time") + 1
        End If
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Enabled = False
        Dim c As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
        c.Open()
        Dim cd As New SqlServerCe.SqlCeCommand("delete from matchmaking where Request='Game' and Username='" + Session("Username") + "'", c)
        cd.ExecuteNonQuery()
        Button4.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = False
        Session("Time") = 0
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = False
        Button5.Enabled = True
        Dim con As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
        con.Open()
        Dim cmdrec As New SqlServerCe.SqlCeCommand("delete from moves where Username='" + Session("Username") + "'", con)
        cmdrec.ExecuteNonQuery()
        Dim cmd As New SqlServerCe.SqlCeCommand("Select Username,Robot,[To] from Matchmaking where Request='Game' and Username='" + TextBox1.Text + "', and [To]='" + Session("Username") + "'", con)
        Dim cmd2 As New SqlServerCe.SqlCeCommand("insert into matchmaking values(NewId(),'Game','" + Session("Username") + "','" + Session("Robot") + "','" + TextBox1.Text + "')", con)
        Dim read As SqlServerCe.SqlCeDataReader
        read = cmd.ExecuteReader()
        Button4.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
        If read.Read() Then
            Session("Adversar") = read.GetString(0)
            Session("Ebot") = read.GetString(1)
            Session("Round") = 0
            Session("Textbox") = " "
            Dim cmd3 As New SqlServerCe.SqlCeCommand("insert into matchmaking values(NewId(),'Join','" + Session("Username") + "','" + Session("Robot") + "','" + Session("Adversar") + "')", con)
            Dim cmd4 As New SqlServerCe.SqlCeCommand("delete from matchmaking where Request='Game' and Username='" + Session("Adversar") + "'", con)

            cmd4.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            Session("Begin") = 2
            Response.Redirect("joaca-pasFinal.aspx")
        Else
            cmd2.ExecuteNonQuery()
            Timer1.Enabled = True
            Session("Time") = 0
        End If

    End Sub
End Class