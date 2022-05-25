Public Module Kata
    Public Function IsDivisible(ByVal n As Integer, ByVal x As Integer, ByVal y As Integer) As Boolean
        If n Mod x = 0 And n Mod y = 0 Then Return True
        Return False
    End Function
End Module
