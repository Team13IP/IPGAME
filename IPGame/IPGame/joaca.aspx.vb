Imports IPGame.ServiceReference1

Public Class WebForm3
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

        Dim inr1 As New ChampDataRequest(1)
        Dim inr2 As New ChampDataRequest(2)
        Dim inr3 As New ChampDataRequest(3)
        Dim in1 As ChampDataResponse
        Dim in2 As ChampDataResponse
        Dim in3 As ChampDataResponse
        in1 = s.ChampData(inr1)
        in2 = s.ChampData(inr2)
        in3 = s.ChampData(inr3)
        Label1.Text = "Atac:" + in1.ChampDataResult.ma1.ToString + "x Aparare:" + in1.ChampDataResult.md1.ToString + "x"
        Label2.Text = "Atac:" + in1.ChampDataResult.ma2.ToString + "x Aparare:" + in1.ChampDataResult.md2.ToString + "x"
        Label3.Text = "Atac:" + in1.ChampDataResult.ma3.ToString + "x Aparare:" + in1.ChampDataResult.md3.ToString + "x"
        Label7.Text = "Atac:" + in2.ChampDataResult.ma1.ToString + "x Aparare:" + in2.ChampDataResult.md1.ToString + "x"
        Label8.Text = "Atac:" + in2.ChampDataResult.ma2.ToString + "x Aparare:" + in2.ChampDataResult.md2.ToString + "x"
        Label9.Text = "Atac:" + in2.ChampDataResult.ma3.ToString + "x Aparare:" + in2.ChampDataResult.md3.ToString + "x"
        Label4.Text = "Atac:" + in3.ChampDataResult.ma1.ToString + "x Aparare:" + in3.ChampDataResult.md1.ToString + "x"
        Label5.Text = "Atac:" + in3.ChampDataResult.ma2.ToString + "x Aparare:" + in3.ChampDataResult.md2.ToString + "x"
        Label6.Text = "Atac:" + in3.ChampDataResult.ma3.ToString + "x Aparare:" + in3.ChampDataResult.md3.ToString + "x"
        RadioButton1.GroupName = "George"
        RadioButton2.GroupName = "George"
        RadioButton3.GroupName = "George"
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

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If (RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton3.Checked = True) And Session("Logat") = 1 Then
            Dim con As New SqlServerCe.SqlCeConnection("Data Source=|DataDirectory|\Database1.sdf")
            con.Open()
            Dim cmdrec As New SqlServerCe.SqlCeCommand("delete from matchmaking where Username='" + Session("Username") + "'", con)
            cmdrec.ExecuteNonQuery()

            Response.Redirect("joaca-pas2.aspx")
        End If
    End Sub

    Protected Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
         
            Dim c As New Service1Client
            Dim c1 As New ChampNameRequest(1)
            Dim c2 As ChampNameResponse = c.ChampName(c1)

            Session("Robot") = c2.ChampNameResult.ToString

        End If

    End Sub

    Protected Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            

            Dim c As New Service1Client
            Dim c1 As New ChampNameRequest(2)
            Dim c2 As ChampNameResponse = c.ChampName(c1)

            Session("Robot") = c2.ChampNameResult.ToString


        End If
    End Sub

    Protected Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
           
            Dim c As New Service1Client
            Dim c1 As New ChampNameRequest(3)
            Dim c2 As ChampNameResponse = c.ChampName(c1)

            Session("Robot") = c2.ChampNameResult.ToString
        End If
    End Sub

    
End Class