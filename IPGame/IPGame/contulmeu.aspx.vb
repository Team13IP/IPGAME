Imports IPGame.ServiceReference1

Public Class WebForm2
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

        ''partea de informatii personale
        If Session("Logat") = 1 Then
            Dim p As New ClasamentusrRequest(Session("Username"))
            Dim p1 As ClasamentusrResponse
            p1 = s.Clasamentusr(p)
            Label1.Visible = True
            Label1.Text = p1.ClasamentusrResult.Username.ToString
            Label2.Visible = True
            Label2.Text = p1.ClasamentusrResult.Victorii.ToString()
            Label3.Visible = True
            Label3.Text = p1.ClasamentusrResult.Infrangeri.ToString
            Label4.Visible = True
            Label4.Text = p1.ClasamentusrResult.Scor.ToString
            Label5.Visible = True
            Label5.Text = p1.ClasamentusrResult.Rank.ToString
            Dim i As New UserHistoryRequest(Session("Username"))
            Dim ir As UserHistoryResponse = s.UserHistory(i)
            Dim h As Integer = ir.UserHistoryResult.Length
            For k As Integer = 0 To h - 1
                ListBox1.Items.Add(ir.UserHistoryResult(k).Adversar)
                ListBox2.Items.Add(ir.UserHistoryResult(k).Rezultat)
            Next
            Dim m(10, 2) As String
            Try

                For k As Integer = 0 To 9
                    If ListBox1.Items.Count > k Then
                        m(k, 0) = ListBox1.Items(h - k - 1).ToString
                        m(k, 1) = ListBox2.Items(h - k - 1).ToString
                    Else
                        m(k, 0) = "-"
                        m(k, 1) = "-"
                    End If

                Next
            Catch ex As Exception

            End Try
            
            is01.Visible = True
            is02.Visible = True
            is03.Visible = True
            is02.Text = m(0, 0)
            is03.Text = m(0, 1)
            is11.Visible = True
            is12.Visible = True
            is13.Visible = True
            is12.Text = m(1, 0)
            is13.Text = m(1, 1)
            is21.Visible = True
            is22.Visible = True
            is23.Visible = True
            is22.Text = m(2, 0)
            is23.Text = m(2, 1)
            is31.Visible = True
            is32.Visible = True
            is33.Visible = True
            is32.Text = m(3, 0)
            is33.Text = m(3, 1)
            is41.Visible = True
            is42.Visible = True
            is43.Visible = True
            is42.Text = m(4, 0)
            is43.Text = m(4, 1)
            is51.Visible = True
            is52.Visible = True
            is53.Visible = True
            is52.Text = m(5, 0)
            is53.Text = m(5, 1)
            is61.Visible = True
            is62.Visible = True
            is63.Visible = True
            is62.Text = m(6, 0)
            is63.Text = m(6, 1)
            is71.Visible = True
            is72.Visible = True
            is73.Visible = True
            is72.Text = m(7, 0)
            is73.Text = m(7, 1)
            is81.Visible = True
            is82.Visible = True
            is83.Visible = True
            is82.Text = m(8, 0)
            is83.Text = m(8, 1)
            is91.Visible = True
            is92.Visible = True
            is93.Visible = True
            is92.Text = m(9, 0)
            is93.Text = m(9, 1)
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
        Response.Redirect(Request.RawUrl)
    End Sub

End Class