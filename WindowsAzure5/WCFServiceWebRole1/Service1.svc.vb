' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
<ServiceBehavior(InstanceContextMode:=InstanceContextMode.PerCall, ConcurrencyMode:=ConcurrencyMode.Single)>
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function CheckLogin(ByVal a As String, ByVal b As String) As Integer Implements IService1.CheckLogin
        Dim result As Integer
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select * from UserLogin('" + a + "','" + b + "')", con)
        result = c.ExecuteScalar
        Return result

    End Function


    Function Top10() As CompositeType() Implements IService1.Top10
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open


        Dim c As New SqlClient.SqlCommand("Select * from top10()", con)
        Dim d As SqlClient.SqlDataReader = c.ExecuteReader()
        Dim i As Integer = 0
        Dim a(9) As CompositeType
        While d.Read()
            a(i) = New CompositeType
            a(i).FirstValue = d.Item(0)
            a(i).SecondValue = d.Item(1)
            a(i).ThirdValue = d.Item(2)
            i = i + 1
        End While
        Return a

    End Function
    Function Rank(ByVal user As String) As Integer Implements IService1.Rank
        Dim result As Integer
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select * from GetRank('" + user + "')", con)
        result = c.ExecuteScalar
        Return result

    End Function

    Function Scor(ByVal user As String) As Integer Implements IService1.Scor
        Dim result As Integer
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select * from GetScore('" + user + "')", con)
        result = c.ExecuteScalar
        Return result
    End Function

    Function UserNou(ByVal user As String, ByVal pass As String, ByVal email As String) As Integer Implements IService1.UserNou
        Dim result As Integer
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("EXEC NEWUSER '" + user + "','" + pass + "','" + email + "'", con)
        Try
            result = c.ExecuteNonQuery
        Catch ex As Exception
            Return 0
        End Try

        Return result

    End Function

    Function Clasament() As CompositeType2() Implements IService1.Clasament
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("select * from ranking", con)
        Dim d As SqlClient.SqlDataReader = c.ExecuteReader()
        Dim i As Integer = 0
        Dim a(0) As CompositeType2
        While d.Read()
            ReDim Preserve a(i)
            a(i) = New CompositeType2
            a(i).Username = d.Item(0)
            a(i).Victorii = d.Item(1)
            a(i).Infrangeri = d.Item(2)
            a(i).Scor = d.Item(3)
            a(i).Rank = d.Item(5)
            i = i + 1

        End While

        Return a

    End Function

    Function Clasamentusr(ByVal user As String) As CompositeType2 Implements IService1.Clasamentusr
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select * from ranking where username='" + user + "'", con)
        Dim d As SqlClient.SqlDataReader = c.ExecuteReader()
        Dim a As New CompositeType2
        While d.Read()
            a.Username = d.Item(0)
            a.Victorii = d.Item(1)
            a.Infrangeri = d.Item(2)
            a.Scor = d.Item(3)
            a.Rank = d.Item(5)
        End While
        Return a
    End Function

    Function UserHistory(ByVal user As String) As CompositeType3() Implements IService1.UserHistory
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select * from UHist('" + user + "')", con)
        Dim d As SqlClient.SqlDataReader = c.ExecuteReader()
        Dim i As Integer = 0
        Dim a(0) As CompositeType3
        Dim adversar As String
        Dim rezultat As String
        While d.Read()
            ReDim Preserve a(i)
            a(i) = New CompositeType3
            If d.GetValue(0) = user Then
                adversar = d.GetValue(1)
                If d.GetValue(2) = 1 Then
                    rezultat = "Victorie"
                Else
                    rezultat = "Infrangere"
                End If
            Else
                adversar = d.GetValue(0)
                If d.GetValue(2) = 1 Then
                    rezultat = "Infrangere"
                Else
                    rezultat = "Victorie"
                End If
            End If
            a(i).Adversar = adversar
            a(i).Rezultat = rezultat
            i = i + 1
        End While
        Return a
    End Function

    Function EndGame(ByVal user1 As String, ByVal user2 As String, ByVal char1 As String, ByVal char2 As String, ByVal victor As Integer) As Integer Implements IService1.EndGame
        Dim result As Integer
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("EXEC ENDOFGAME '" + user1 + "','" + user2 + "','" + char1.ToString + "','" + char2.ToString + "','" + victor.ToString + "'", con)
        Try
            result = c.ExecuteNonQuery
        Catch ex As Exception
            Return 0
        End Try

        Return result

    End Function
    Function ChampData(ByVal d As Integer) As CompositeType4 Implements IService1.ChampData
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select Mof1, Mof2, Mof3, Mdef1, Mdef2, Mdef3 from Personaje where ID=" + d.ToString, con)
        Dim a As New CompositeType4
        Dim b As SqlClient.SqlDataReader = c.ExecuteReader()
        Try
            b.Read()
            a.ma1 = b.GetValue(0)
            a.ma2 = b.GetValue(1)
            a.ma3 = b.GetValue(2)
            a.md1 = b.GetValue(3)
            a.md2 = b.GetValue(4)
            a.md3 = b.GetValue(5)
            a.ma1 = Math.Round(a.ma1, 2)
            a.ma2 = Math.Round(a.ma2, 2)
            a.ma3 = Math.Round(a.ma3, 2)
            a.md1 = Math.Round(a.md1, 2)
            a.md2 = Math.Round(a.md2, 2)
            a.md3 = Math.Round(a.md3, 2)
        Catch

        End Try
        Return a

    End Function
    Function ChampName(ByVal d As Integer) As String Implements IService1.ChampName
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select Nume from Personaje where ID=" + d.ToString, con)
        Dim k As String = c.ExecuteScalar


        Return k
    End Function
    '' Label ataca cu Rachete/ cu Laser/
    '' Label se apara impotriva Rachetelor/Laserului/Loviturilor fizice
    '' 
    Function BotFight(ByVal Atacker As String, ByVal myrobot As String, ByVal myaction As Integer, ByVal hisrobot As String, ByVal hisaction As Integer) As CompositeType5 Implements IService1.BotFight
        Dim result As New CompositeType5
        Dim atk As String = ""
        Dim def As String = ""
        Dim ab As New SqlClient.SqlConnectionStringBuilder
        ab.DataSource = "tkz112mtbd.database.windows.net"
        ab.InitialCatalog = "IPGame"
        ab.Encrypt = True
        ab.TrustServerCertificate = False
        ab.UserID = "usr"
        ab.Password = "IPGame12"
        Dim con As New SqlClient.SqlConnection(ab.ToString)
        Do
            Try
                con.Open()
            Catch ex As Exception

            End Try

        Loop Until con.State = ConnectionState.Open
        Dim c As New SqlClient.SqlCommand("Select Mof1, Mof2, Mof3, Mdef1, Mdef2, Mdef3 from Personaje where Nume='" + myrobot + "'", con)
        Dim b As SqlClient.SqlDataReader = c.ExecuteReader

        Dim mymod As Double
        Dim hismod As Double
        b.Read()
        result.text = ""
        If Atacker = "Me" Then
            If myaction = 1 Then
                atk = "cu Rachete"
            End If
            If myaction = 2 Then
                atk = "cu Laser"
            End If
            If myaction = 3 Then
                atk = "Melee"
            End If
            If hisaction = 1 Then
                def = "antiRachete"
            End If
            If hisaction = 2 Then
                def = "antiLaser"
            End If
            If hisaction = 3 Then
                def = "Melee"
            End If
            mymod = Math.Round(b.GetValue(myaction - 1), 2)
        Else
            If myaction = 1 Then
                atk = "antiRachete"
            End If
            If myaction = 2 Then
                atk = "antiLaser"
            End If
            If myaction = 3 Then
                atk = "Melee"
            End If
            If hisaction = 1 Then
                def = "cu Rachete"
            End If
            If hisaction = 2 Then
                def = "cu Laser"
            End If
            If hisaction = 3 Then
                def = "Melee"
            End If
            mymod = Math.Round(b.GetValue(myaction + 2), 2)
        End If
        b.Close()
        Dim c1 = New SqlClient.SqlCommand("Select Mof1, Mof2, Mof3, Mdef1, Mdef2, Mdef3 from Personaje where Nume='" + hisrobot + "'", con)
        b = c1.ExecuteReader
        b.Read()
        If Atacker = "Me" Then

            hismod = Math.Round(b.GetValue(hisaction + 2), 2)
        Else
            hismod = Math.Round(b.GetValue(hisaction - 1), 2)
        End If

        If Atacker = "Me" Then
            Dim dmg As Integer = 20
            If myaction = hisaction Then
                hismod = hismod * 2
            End If
            result.dmg = dmg * mymod / hismod
        Else
            Dim dmg As Integer = 20
            If myaction = hisaction Then
                mymod = mymod * 2
            End If
            result.dmg = dmg * hismod / mymod
        End If
        If Atacker = "Me" Then
            result.text = result.text + myrobot + " ataca " + atk + vbNewLine + hisrobot + " se apara " + def + " rezultand " + result.dmg.ToString + " puncte dauna"
        Else
            result.text = result.text + hisrobot + " ataca " + def + vbNewLine + myrobot + " se apara " + atk + " rezultand " + result.dmg.ToString + " puncte dauna"
        End If

        Return result
    End Function
End Class
