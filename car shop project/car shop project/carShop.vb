Module carShop
    Public Structure Tcar
        Public recordId As Short
        <VBFixedString(20)> Public Make As String
        <VBFixedString(15)> Public Model As String
        <VBFixedString(10)> Public Colour As String
        Public Year As Short
        Public Mileage As Integer
        Public Price As Integer
        <VBFixedString(7)> Public RegistrationNumber As String
        <VBFixedString(25)> Public FileName As String
        <VBFixedString(255)> Public Comments As String
        Public Sold As Boolean
        <VBFixedString(20)> Public SalesPerson As String
        Public DateSold As Date
    End Structure

    Public ThisCar As Tcar
    Public position As Integer

End Module
