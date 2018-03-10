Public Class NumericPair
    Implements IComparable

#Region " Variables "
    Public x As Integer = 0
    Public y As String = 0
#End Region

    Public Sub New()
        x = 0
        y = 0
    End Sub

    Public Sub New(ByVal num1 As Integer, ByVal num2 As Integer)
        x = num1
        y = num2
    End Sub

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo

        'where the Sorting logic is run

        'Basically says: "if ME greater than the obj card then return 1, if equal return 0 and if less than, return -1"
        If Not TypeOf obj Is NumericPair Then Throw New ArgumentException 'make sure obj is a AlphaNumericPair before continuing

        Dim other As NumericPair = CType(obj, NumericPair)


        If x < other.x Then
            Return -1
        ElseIf x > other.x Then
            Return 1
        Else
            If y < other.y Then
                Return -1
            ElseIf y > other.y Then
                Return 1
            Else
                Return 0
            End If
        End If
    End Function

End Class
