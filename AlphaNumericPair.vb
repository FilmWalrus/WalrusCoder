Public Class AlphaNumericPair
    Implements IComparable

#Region " Variables "
    Public Number As Integer = 0
    Public Letter As String = "*"
#End Region

    Public Sub New()
        Number = 0
        Letter = "*"
    End Sub

    Public Sub New(ByVal num As Integer, ByVal str As String)
        Number = num
        Letter = str
    End Sub

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo

        'where the Sorting logic is run

        'Basically says: "if ME greater than the obj card then return 1, if equal return 0 and if less than, return -1"
        If Not TypeOf obj Is AlphaNumericPair Then Throw New ArgumentException 'make sure obj is a AlphaNumericPair before continuing

        Dim other As AlphaNumericPair = CType(obj, AlphaNumericPair)


        If Number < other.Number Then
            Return -1
        ElseIf Number > other.Number Then
            Return 1
        Else
            If Letter < other.Letter Then 'Lexigraphic
                Return -1
            ElseIf Letter > other.Letter Then
                Return 1
            Else
                Return 0
            End If
        End If
    End Function

End Class
