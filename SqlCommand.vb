Imports System.Data.SQLite

Class SqlCommand
    'Private dbCommand As String = ""
    Public PblDataTable As New DataTable
    Public bindingSrc As BindingSource
    Shared dbName As String = "data.db"
    Shared dbPath As String = Application.StartupPath & "\" & dbName
    Shared objConString As String = "Data Source=" & dbPath
    Shared objConnection As New SQLiteConnection(objConString)
    Shared objCommand As New SQLiteCommand("", objConnection)
    Public Shared ID As Integer

    Shared OR_Number As Integer
    Shared Total_Items As Integer
    Shared Total, Discount, Cash, Change As Double
    Public Enum CommandType
        UPDATE
        DELETE
        ADD
        READ
        GETID
        NONE
    End Enum
    Public Shared WriteOnly Property Get_OrNumber As Integer
        Set(value As Integer)
            OR_Number = value
        End Set
    End Property
    Public Shared WriteOnly Property Get_TotalItems As Integer
        Set(value As Integer)
            Total_Items = value
        End Set
    End Property
    Public Shared WriteOnly Property Get_Total As Double
        Set(value As Double)
            Total = value
        End Set
    End Property

    Public Shared WriteOnly Property Get_Discount As Double
        Set(value As Double)
            Discount = value
        End Set
    End Property

    Public Shared WriteOnly Property Get_Cash As Double
        Set(value As Double)
            Cash = value
        End Set
    End Property

    Public Shared WriteOnly Property Get_Change As Double
        Set(value As Double)
            Change = value
        End Set
    End Property

    Public Shared Function PushCommand(cmd As String, commandType As CommandType) As Boolean
        If objConnection.State = ConnectionState.Closed Then
            objConnection.Open()
            If objConnection.State = ConnectionState.Open Then
                ExecuteCommand(cmd, commandType)
            End If
        End If
        Return True
    End Function
    Public Function AddData() As Boolean
        objCommand.Parameters.Clear()
        objCommand.Parameters.AddWithValue("@OrderNumber", OR_Number)
        objCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss"))
        objCommand.Parameters.AddWithValue("@ItemCount", Total_Items)
        objCommand.Parameters.AddWithValue("@Total", Total)
        objCommand.Parameters.AddWithValue("@Discount", Discount)
        objCommand.Parameters.AddWithValue("@Cash", Cash)
        objCommand.Parameters.AddWithValue("@Change", Change)
        Return True
    End Function
    Private Shared Sub ExecuteCommand(Optional cmd As String = Nothing, Optional commandType As CommandType = CommandType.NONE)
        Select Case commandType
            Case CommandType.READ
                Try
                    objCommand.Parameters.Clear()
                    objCommand.CommandText = cmd
                    Dim objAdapter As New SQLiteDataAdapter(objCommand)
                    Dim objSet As New DataSet
                    objAdapter.Fill(objSet, "tblRecords")
                    'History.PrvTable = objSet.Tables("tblRecords")
                    Main.GetTable = objSet.Tables("tblRecords")
                    objConnection.Close()
                Catch ex As Exception
                End Try
            Case CommandType.ADD
                objCommand.CommandText = cmd
                objCommand.Parameters.Clear()
                objCommand.Parameters.AddWithValue("@OrderNumber", OR_Number)
                objCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                objCommand.Parameters.AddWithValue("@ItemCount", Total_Items)
                objCommand.Parameters.AddWithValue("@Total", Total)
                objCommand.Parameters.AddWithValue("@Discount", Discount)
                objCommand.Parameters.AddWithValue("@Cash", Cash)
                objCommand.Parameters.AddWithValue("@Change", Change)
                objCommand.ExecuteNonQuery()
                objConnection.Close()
            Case CommandType.GETID
                objCommand.CommandText = cmd
                Dim objReader As SQLiteDataReader = objCommand.ExecuteReader()
                If objReader.HasRows Then
                    While objReader.Read()
                        ID = objReader.GetInt32(1)
                    End While
                    objConnection.Close()
                End If

        End Select

        'Try
        '    If cmd Is Nothing Then
        '        objCommand.CommandText = "SELECT * FROM tblRecords ORDER BY ID DESC"
        '    Else
        '        objCommand = cmd
        '    End If

        '    Dim objAdapter As New SQLiteDataAdapter(objCommand)
        '    Dim objSet As New DataSet
        '    objAdapter.Fill(objSet, "tblRecords")
        '    History.PrvTable = objSet.Tables("tblRecords")
        '    ''bindingSrc = New BindingSource()
        '    ''bindingSrc.DataSource = objSet.Tables("tblRecords")

        'Catch ex As Exception

        'End Try
    End Sub
End Class
