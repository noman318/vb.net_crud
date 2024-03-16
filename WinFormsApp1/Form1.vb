Imports System.Data.SqlClient


Public Class Form1
    Dim conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saadt\source\repos\WinFormsApp1\WinFormsApp1\Database1.mdf;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(conString)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Sub Edit()
        Try
            conn.Open()
            cmd = New SqlCommand("UPDATE product SET product_name=@product_name,product_price=@product_price,product_group=@product_group,product_expiry=@product_expiry,product_status=@product_status WHERE product_no=@product_no", conn)
            cmd.Parameters.AddWithValue("@product_no", CDec(product_no.Text))
            cmd.Parameters.AddWithValue("@product_name", product_name.Text)
            cmd.Parameters.AddWithValue("@product_price", CDec(product_price.Text))
            cmd.Parameters.AddWithValue("@product_group", product_group.Text)
            cmd.Parameters.AddWithValue("@product_expiry", CDate(product_expiry.Value))
            cmd.Parameters.AddWithValue("@product_status", CBool(product_status.Checked.ToString))
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Check if rows were affected
            If rowsAffected > 0 Then
                MessageBox.Show("Data Updated successfully.")
            Else
                MessageBox.Show("No rows were Updated.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        data_grid_load()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'update button
        Edit()
        data_grid_load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ' clear button
        clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles product_no.TextChanged

    End Sub

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_grid_load()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles product_name.TextChanged

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        data_grid_load()
    End Sub
    Public Sub data_grid_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM product", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("product_no"), dr.Item("product_name"), dr.Item("product_price"), dr.Item("product_group"), dr.Item("product_expiry"), Format(CBool(dr.Item("product_status"))))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub clear()
        product_no.Clear()
        product_name.Clear()
        product_price.Clear()
        product_group.Text = ""
        product_expiry.Value = Now
    End Sub
    Public Sub save()
        Try
            conn.Open()
            cmd = New SqlCommand("INSERT INTO product(product_no,product_name,product_price,product_group,product_expiry,product_status) values (@product_no,@product_name,@product_price,@product_group,@product_expiry,@product_status)", conn)
            cmd.Parameters.AddWithValue("@product_no", CDec(product_no.Text))
            cmd.Parameters.AddWithValue("@product_name", product_name.Text)
            cmd.Parameters.AddWithValue("@product_price", CDec(product_price.Text))
            cmd.Parameters.AddWithValue("@product_group", product_group.Text)
            cmd.Parameters.AddWithValue("@product_expiry", CDate(product_expiry.Value))
            cmd.Parameters.AddWithValue("@product_status", CBool(product_status.Checked.ToString))

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Check if rows were affected
            If rowsAffected > 0 Then
                MessageBox.Show("Data inserted successfully.")
            Else
                MessageBox.Show("No rows were inserted.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub
    Public Sub delete()
        If MsgBox("Are u sure u want to Delete", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New SqlCommand("DELETE FROM product WHERE product_no=@product_no", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@product_no", CDec(product_no.Text))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if rows were affected
                If rowsAffected > 0 Then
                    MessageBox.Show("Data Deleted successfully.")
                Else
                    MessageBox.Show("No rows were Deleted.")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear()
            data_grid_load()
        Else
            Return
        End If
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' delete button
        delete()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles product_status.CheckedChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        product_no.Text = DataGridView1.CurrentRow.Cells(0).Value
        product_name.Text = DataGridView1.CurrentRow.Cells(1).Value
        product_price.Text = DataGridView1.CurrentRow.Cells(2).Value
        product_group.Text = DataGridView1.CurrentRow.Cells(3).Value
        product_expiry.Text = DataGridView1.CurrentRow.Cells(4).Value
        product_status.Checked = DataGridView1.CurrentRow.Cells(5).Value

        product_no.ReadOnly = True
        btn_save.Enabled = False
    End Sub

    Private Sub text_search_TextChanged(sender As Object, e As EventArgs) Handles text_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM product WHERE product_no like '%" & text_search.Text & "%' product_name like '%" & text_search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("product_no"), dr.Item("product_name"), dr.Item("product_price"), dr.Item("product_group"), dr.Item("product_expiry"), Format(CBool(dr.Item("product_status"))))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
