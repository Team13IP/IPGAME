Imports IPGame.ServiceReference1
Imports System.Xml
Public Class WebForm5
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
            Button1.Text = "Logout"
            Password.Visible = False
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

        ''parte load userinformation
       
        Label1.Text = Session("Username")
        Label2.Text = Session("Robot")
        Label3.Text = Session("Rank")

        If Session("Round") = 0 Then
            Session("HP") = 100
            Session("EP") = 100
        End If
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Label4.Text = Session("HP")
        Label8.Text = Session("EP")
        Label5.Text = Session("Adversar")
        If Session("Adversar") = "TestBot" Then

            Label6.Text = "Robotix"
            Label7.Text = "-"
        Else
            Label6.Text = Session("Ebot")
            Dim j As New RankRequest(Session("Adversar"))
            Dim j1 As RankResponse = s.Rank(j)
            Label7.Text = j1.RankResult.ToString
        End If
        Image1.ImageUrl = "imagini/" + Label2.Text.ToLower + ".png"
        Image2.ImageUrl = "imagini/" + Label6.Text.ToLower + ".png"
        If Session("Adversar") = "TestBot" And Session("Round") = 0 Then
            Dim rnd As New Random
            Session("Begin") = rnd.Next(1, 3)
            Session("Round") = 1
        ElseIf Session("Round") = 0 Then
            Session("Round") = 1
        End If

        If Session("Begin") = 1 And Session("Round") = 1 Then
            Label9.Text = "Runda ofensiva"
            Session("Textbox") = "Round " + Session("Round").ToString
        ElseIf Session("Begin") = 2 And Session("Round") = 1 Then
            Label9.Text = "Runda defensiva"
            Session("Textbox") = "Round " + Session("Round").ToString
        Else
            If Session("Begin") = 1 And Session("Round") Mod 2 = 0 Then
                Label9.Text = "Runda defensiva"
            End If
            If Session("Begin") = 1 And Session("Round") Mod 2 = 1 Then
                Label9.Text = "Runda ofensiva"
            End If
            If Session("Begin") = 2 And Session("Round") Mod 2 = 1 Then
                Label9.Text = "Runda defensiva"
            End If
            If Session("Begin") = 2 And Session("Round") Mod 2 = 0 Then
                Label9.Text = "Runda ofensiva"
            End If
        End If
        TextBox1.Text = Session("Textbox")

        Try
            Label10.Text = Session("Round").ToString
        Catch ex As Exception
            Response.Redirect("index.aspx")
        End Try
        If Session("Begin") = 0 Then
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        End If




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

    Public Sub mydmg(ByVal dmg As Integer)
        Session("HP") = Session("HP") - dmg
        If Session("HP") <= 0 Then
            Label9.Text = "Ai pierdut"
            Session("Round") = 0
            Session("Begin") = 0
            Label4.Text = "0"
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        Else
            Response.Redirect(Request.RawUrl)
        End If


    End Sub
    Public Sub hisdmg(ByVal dmg As Integer)
        Session("EP") = Session("EP") - dmg
        If Session("EP") <= 0 Then
            Label9.Text = "Ai castigat"
            Session("Round") = 0
            Session("Begin") = 0
            Label8.Text = "0"
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        

            If Session("Adversar") <> "TestBot" Then
                Dim s As New Service1Client
                Dim s1 As New EndGameRequest(Label1.Text, Label5.Text, Label2.Text, Label6.Text, 1)
                s.EndGame(s1)
            End If
        Else
            Response.Redirect(Request.RawUrl)
        End If

    End Sub
    Public Sub moderateround(ByVal q As Integer)
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Dim s As New Service1Client
        Dim con As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
        con.Open()
          Session("Time") = 0
        Dim cmd As New SqlServerCe.SqlCeCommand("insert into Moves values(NewID()," + Session("Round").ToString + ",'" + Session("Username") + "'," + q.ToString + ")", con)
        Session("Move") = q
        cmd.ExecuteNonQuery()
        If Session("Adversar") = "TestBot" Then
            Dim r As New Random
            Dim mv As Integer = r.Next(1, 4)
            Dim cmd1 As New SqlServerCe.SqlCeCommand("insert into Moves values(NewID()," + Session("Round").ToString + ",'TestBot'," + mv.ToString + ")", con)
            cmd1.ExecuteNonQuery()
            Dim cmd2 As New SqlServerCe.SqlCeCommand("delete from moves where username='TestBot'", con)
            Dim cmd3 As New SqlServerCe.SqlCeCommand("delete from moves where username='" + Session("Username") + "'", con)
            cmd2.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            If Label9.Text = "Runda ofensiva" Then

                Dim ca As New BotFightRequest("Me", Label2.Text, Session("Move"), Label6.Text, mv)
                Dim cb As BotFightResponse = s.BotFight(ca)
                Session("Round") = Session("Round") + 1
                Session("Textbox") = cb.BotFightResult.text + vbNewLine + Session("Textbox")
                Session("Textbox") = "Round " + Session("Round").ToString + vbNewLine + Session("Textbox")
                TextBox1.Text = Session("Textbox")
                hisdmg(cb.BotFightResult.dmg)

            ElseIf Label9.Text = "Runda defensiva" Then
                Dim ca As New BotFightRequest("him", Label2.Text, Session("Move"), Label6.Text, mv)
                Dim cb As BotFightResponse = s.BotFight(ca)
                Session("Round") = Session("Round") + 1
                Session("Textbox") = cb.BotFightResult.text + vbNewLine + Session("Textbox")
                Session("Textbox") = "Round " + Session("Round").ToString + vbNewLine + Session("Textbox")
                TextBox1.Text = Session("Textbox")
                mydmg(cb.BotFightResult.dmg)
            End If
        Else
            Timer2.Enabled = True
        End If
           End Sub




    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 20000 Then
            Timer1.Interval = 20000
            Response.Redirect("index.aspx")
        End If
        Label9.Text = "Lipsa activitate, meci incheiat"
        Dim con As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
        con.Open()
        Dim cmd3 As New SqlServerCe.SqlCeCommand("delete from moves where username='" + Session("Username") + "'", con)
        cmd3.ExecuteNonQuery()
        Timer1.Interval = 20000
        Session("Begin") = 0



    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        moderateround(1)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        moderateround(2)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        moderateround(3)
    End Sub


    Protected Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim con As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
        con.Open()
        Dim cmd3 As New SqlServerCe.SqlCeCommand("delete from moves where username='" + Session("Username") + "'", con)
          Dim cmd1 As New SqlServerCe.SqlCeCommand("select move from moves where Round=" + Session("Round").ToString + " and username='" + Session("Adversar") + "'", con)
        Dim r As SqlServerCe.SqlCeDataReader = cmd1.ExecuteReader
        Dim g As Integer
        If Session("Time") = 20 Then
            Label9.Text = "Probleme de conexiune, meci incheiat"
            Session("Begin") = 0
            cmd3.ExecuteNonQuery()
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        End If
        If Session("Adversar") <> "TestBot" Then

            If r.Read() Then
                g = r.GetValue(0)
                Dim cmd2 As New SqlServerCe.SqlCeCommand("delete from moves where Round=" + Session("Round").ToString + " and username='" + Session("Adversar") + "'", con)
                Dim k As Integer = cmd2.ExecuteNonQuery()
                 If Label9.Text = "Runda ofensiva" Then
                    Dim s As New Service1Client
                    Dim ca As New BotFightRequest("Me", Label2.Text, Session("Move"), Label6.Text, g)
                    Dim cb As BotFightResponse = s.BotFight(ca)
                    Session("Round") = Session("Round") + 1
                    Session("Textbox") = cb.BotFightResult.text + vbNewLine + Session("Textbox")
                    Session("Textbox") = "Round " + Session("Round").ToString + vbNewLine + Session("Textbox")
                    hisdmg(cb.BotFightResult.dmg)
                    Timer2.Enabled = False
                    Session("Time") = 0
                ElseIf Label9.Text = "Runda defensiva" Then
                    Dim s As New Service1Client
                    Dim ca As New BotFightRequest("him", Label2.Text, Session("Move"), Label6.Text, g)
                    Dim cb As BotFightResponse = s.BotFight(ca)
                    Session("Round") = Session("Round") + 1
                    Session("Textbox") = cb.BotFightResult.text + vbNewLine + Session("Textbox")
                    Session("Textbox") = "Round " + Session("Round").ToString + vbNewLine + Session("Textbox")
                    mydmg(cb.BotFightResult.dmg)
                    Timer2.Enabled = False
                    Session("Time") = 0
                End If

            Else
                Session("Time") = Session("Time") + 1
            End If

        End If



    End Sub
End Class