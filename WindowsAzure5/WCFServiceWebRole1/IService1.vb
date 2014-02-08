' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function CheckLogin(ByVal a As String, ByVal v As String) As Integer
    <OperationContract()>
    Function Top10() As CompositeType()
    <OperationContract()>
    Function Rank(ByVal user As String) As Integer
    <OperationContract()>
    Function Scor(ByVal user As String) As Integer
    <OperationContract()>
    Function UserNou(ByVal user As String, ByVal pass As String, ByVal email As String) As Integer
    <OperationContract()>
    Function Clasament() As CompositeType2()
    <OperationContract()>
    Function Clasamentusr(ByVal user As String) As CompositeType2
    <OperationContract()>
    Function UserHistory(ByVal user As String) As CompositeType3()
    <OperationContract()>
    Function EndGame(ByVal user1 As String, ByVal user2 As String, ByVal char1 As String, ByVal char2 As String, ByVal victor As Integer) As Integer
    <OperationContract()>
    Function ChampData(ByVal c As Integer) As CompositeType4
    <OperationContract()>
    Function ChampName(ByVal c As Integer) As String
    <OperationContract()>
    Function BotFight(ByVal Atacker As String, ByVal myrobot As String, ByVal myaction As Integer, ByVal hisrobot As String, ByVal hisaction As Integer) As CompositeType5
    ' TODO: Add your service operations here
End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property FirstValue As String
    <DataMember()>
    Public Property SecondValue As String
    <DataMember()>
    Public Property ThirdValue As String

End Class
<DataContract()>
Public Class CompositeType2

    <DataMember()>
    Public Property Rank As Integer
    <DataMember()>
    Public Property Username As String
    <DataMember()>
    Public Property Victorii As Integer
    <DataMember()>
    Public Property Infrangeri As Integer
    <DataMember()>
    Public Property Scor As Integer


End Class
<DataContract()>
Public Class CompositeType3

    <DataMember()>
    Public Property Adversar As String
    <DataMember()>
    Public Property Rezultat As String
 

End Class

Public Class CompositeType4

    <DataMember()>
    Public Property ma1 As Double
    <DataMember()>
    Public Property ma2 As Double
    <DataMember()>
    Public Property ma3 As Double
    <DataMember()>
    Public Property md1 As Double
    <DataMember()>
    Public Property md2 As Double
    <DataMember()>
    Public Property md3 As Double

End Class

Public Class CompositeType5

    <DataMember()>
    Public Property dmg As Integer
    <DataMember()>
    Public Property text As String
   
End Class