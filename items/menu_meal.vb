Public Class menu_meal
    Public Shared this_instance As menu_meal
    Public Shared ReadOnly Property Instance() As menu_meal
        Get
            If IsNothing(this_instance) Then
                Dim meal As New menu_meal()
                Return meal
            End If
#Disable Warning BC42107 ' Property doesn't return a value on all code paths
        End Get
#Enable Warning BC42107 ' Property doesn't return a value on all code paths
    End Property
End Class
