﻿Public Class Barrio
    Public Property ID_BARRIO As Integer
    Public Property nombre As String
    Public Property provincia As String

    Public Overrides Function toString() As String
        Return nombre
    End Function
End Class
