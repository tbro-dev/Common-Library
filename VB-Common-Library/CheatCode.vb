Public Class CheatCode
    Public Class Calculator
        Private value1, value2, result As Double
        Private index1 As Integer = 0

        Public Sub New()
            ' Constructor
        End Sub

        Public Sub Clear()
            value1 = 0
            value2 = 0
            result = 0
            index1 = 0
        End Sub

        Public Function PerformOperation(operation As Integer, inputValue As Double) As Double
            Select Case operation
                Case 1 ' Addition
                    value1 = inputValue
                    index1 = 1
                    Return 0
                Case 2 ' Subtraction
                    value1 = inputValue
                    index1 = 2
                    Return 0
                Case 3 ' Multiplication
                    value1 = inputValue
                    index1 = 3
                    Return 0
                Case 4 ' Equals
                    value2 = inputValue
                    If index1 = 1 Then
                        result = value1 + value2
                    ElseIf index1 = 2 Then
                        result = value1 - value2
                    ElseIf index1 = 3 Then
                        result = value1 * value2
                    End If
                    index1 = 0
                    Return result
                Case Else
                    If index1 = 0 Then
                        Return inputValue
                    Else
                        Return 0
                    End If
            End Select
        End Function
    End Class

End Class
