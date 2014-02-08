Imports IPGame.ServiceReference1
Public Class Clasament
    Inherits System.Web.UI.Page
    Public Sub loadclas()
        If Session("Claspg") = 1 Then
            cm01.Text = "1."
            
            cm11.Text = "2."
            cm21.Text = "3."
            cm31.Text = "4."
            cm41.Text = "5."
            cm51.Text = "6."
            cm61.Text = "7."
            cm71.Text = "8."
            cm81.Text = "9."
            cm91.Text = "10."
        Else
            Dim clm As Integer = Session("Claspg")
            Dim cam As Integer = clm - 1
            cm01.Text = cam.ToString + "1."
            cm11.Text = cam.ToString + "2."
            cm21.Text = cam.ToString + "3."
            cm31.Text = cam.ToString + "4."
            cm41.Text = cam.ToString + "5."
            cm51.Text = cam.ToString + "6."
            cm61.Text = cam.ToString + "7."
            cm71.Text = cam.ToString + "8."
            cm81.Text = cam.ToString + "9."
            cm91.Text = clm.ToString + "0."
        End If
        Dim item As New WebControls.ListItem(cm01.Text)
        Dim a As Integer = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm02.Text = "-"
            cm03.Text = "-"
            cm04.Text = "-"
            cm05.Text = "-"
        Else
            cm02.Text = ListBox2.Items(a).ToString
            cm03.Text = ListBox3.Items(a).ToString
            cm04.Text = ListBox4.Items(a).ToString
            cm05.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm11.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm12.Text = "-"
            cm13.Text = "-"
            cm14.Text = "-"
            cm15.Text = "-"
        Else
            cm12.Text = ListBox2.Items(a).ToString
            cm13.Text = ListBox3.Items(a).ToString
            cm14.Text = ListBox4.Items(a).ToString
            cm15.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm21.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm22.Text = "-"
            cm23.Text = "-"
            cm24.Text = "-"
            cm25.Text = "-"
        Else
            cm22.Text = ListBox2.Items(a).ToString
            cm23.Text = ListBox3.Items(a).ToString
            cm24.Text = ListBox4.Items(a).ToString
            cm25.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm31.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm32.Text = "-"
            cm33.Text = "-"
            cm34.Text = "-"
            cm35.Text = "-"
        Else
            cm32.Text = ListBox2.Items(a).ToString
            cm33.Text = ListBox3.Items(a).ToString
            cm34.Text = ListBox4.Items(a).ToString
            cm35.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm41.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm42.Text = "-"
            cm43.Text = "-"
            cm44.Text = "-"
            cm45.Text = "-"
        Else
            cm42.Text = ListBox2.Items(a).ToString
            cm43.Text = ListBox3.Items(a).ToString
            cm44.Text = ListBox4.Items(a).ToString
            cm45.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm51.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm52.Text = "-"
            cm53.Text = "-"
            cm54.Text = "-"
            cm55.Text = "-"
        Else
            cm52.Text = ListBox2.Items(a).ToString
            cm53.Text = ListBox3.Items(a).ToString
            cm54.Text = ListBox4.Items(a).ToString
            cm55.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm61.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm62.Text = "-"
            cm63.Text = "-"
            cm64.Text = "-"
            cm65.Text = "-"
        Else
            cm62.Text = ListBox2.Items(a).ToString
            cm63.Text = ListBox3.Items(a).ToString
            cm64.Text = ListBox4.Items(a).ToString
            cm65.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm71.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm72.Text = "-"
            cm73.Text = "-"
            cm74.Text = "-"
            cm75.Text = "-"
        Else
            cm72.Text = ListBox2.Items(a).ToString
            cm73.Text = ListBox3.Items(a).ToString
            cm74.Text = ListBox4.Items(a).ToString
            cm75.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm81.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm82.Text = "-"
            cm83.Text = "-"
            cm84.Text = "-"
            cm85.Text = "-"
        Else
            cm82.Text = ListBox2.Items(a).ToString
            cm83.Text = ListBox3.Items(a).ToString
            cm84.Text = ListBox4.Items(a).ToString
            cm85.Text = ListBox5.Items(a).ToString
        End If
        item = New WebControls.ListItem(cm91.Text)
        a = ListBox1.Items.IndexOf(item)
        If a = -1 Then
            cm92.Text = "-"
            cm93.Text = "-"
            cm94.Text = "-"
            cm95.Text = "-"
        Else
            cm92.Text = ListBox2.Items(a).ToString
            cm93.Text = ListBox3.Items(a).ToString
            cm94.Text = ListBox4.Items(a).ToString
            cm95.Text = ListBox5.Items(a).ToString
        End If
    End Sub
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

        '' de aici page.load lucreaza doar pt pagina curenta

        Dim cl As New ClasamentRequest()
        Dim ca As ClasamentResponse = s.Clasament(cl)
        For i As Integer = 0 To ca.ClasamentResult.Length - 1 Step +1
            ListBox1.Items.Add(ca.ClasamentResult(i).Rank.ToString + ".")
            ListBox2.Items.Add(ca.ClasamentResult(i).Username.ToString)
            ListBox3.Items.Add(ca.ClasamentResult(i).Victorii.ToString)
            ListBox4.Items.Add(ca.ClasamentResult(i).Infrangeri.ToString)
            ListBox5.Items.Add(ca.ClasamentResult(i).Scor.ToString)
        Next

        loadclas()


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

   
    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton1.Click
        If Session("Claspg") > 1 Then
            Session("Claspg") = Session("Claspg") - 1
            LinkButton1.PostBackUrl = "#" + Session("Claspg").ToString

        End If
        loadclas()
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton2.Click

        Session("Claspg") = Session("Claspg") + 1
        LinkButton2.PostBackUrl = "#" + Session("Claspg").ToString
        loadclas()

    End Sub
End Class