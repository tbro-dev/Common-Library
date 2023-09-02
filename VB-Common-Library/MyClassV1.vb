Public Class MyClassV1
    Private _myField As Integer

    Public Property MyProperty As Integer
        Get
            Return _myField
        End Get
        Set(value As Integer)
            _myField = value
        End Set
    End Property
End Class

' Creating an instance of MyClassV1
'Dim myObject As New MyClassV1()

' Accessing the property, which involves calling the getter method
'Dim value As Integer = myObject.MyProperty

' Modifying the property, which involves calling the setter method
'myObject.MyProperty = 42
