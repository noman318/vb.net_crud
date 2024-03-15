<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        product_no = New TextBox()
        product_price = New TextBox()
        product_name = New TextBox()
        product_expiry = New DateTimePicker()
        btn_save = New Button()
        btn_clear = New Button()
        btn_delete = New Button()
        btn_update = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        product_group = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        Label6 = New Label()
        text_search = New TextBox()
        product_status = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' product_no
        ' 
        product_no.Location = New Point(85, 40)
        product_no.Name = "product_no"
        product_no.Size = New Size(262, 27)
        product_no.TabIndex = 0
        ' 
        ' product_price
        ' 
        product_price.Location = New Point(82, 214)
        product_price.Name = "product_price"
        product_price.Size = New Size(262, 27)
        product_price.TabIndex = 2
        ' 
        ' product_name
        ' 
        product_name.Location = New Point(82, 132)
        product_name.Name = "product_name"
        product_name.Size = New Size(262, 27)
        product_name.TabIndex = 3
        ' 
        ' product_expiry
        ' 
        product_expiry.Location = New Point(85, 369)
        product_expiry.Name = "product_expiry"
        product_expiry.Size = New Size(262, 27)
        product_expiry.TabIndex = 4
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(84, 477)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(94, 29)
        btn_save.TabIndex = 6
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' btn_clear
        ' 
        btn_clear.Location = New Point(208, 539)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(94, 29)
        btn_clear.TabIndex = 7
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(80, 539)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(94, 29)
        btn_delete.TabIndex = 8
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_update
        ' 
        btn_update.Location = New Point(208, 477)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(94, 29)
        btn_update.TabIndex = 9
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 10
        Label1.Text = "Product No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(82, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 20)
        Label2.TabIndex = 11
        Label2.Text = "Product Name."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(82, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 12
        Label3.Text = "Product Group"
        ' 
        ' product_group
        ' 
        product_group.FormattingEnabled = True
        product_group.Items.AddRange(New Object() {"SWEETS", "COLD DRINKS"})
        product_group.Location = New Point(82, 295)
        product_group.Name = "product_group"
        product_group.Size = New Size(262, 28)
        product_group.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(85, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 14
        Label4.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(86, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 20)
        Label5.TabIndex = 15
        Label5.Text = "Expiry Date:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(402, 95)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(865, 473)
        DataGridView1.TabIndex = 16
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product no."
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 113
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 79
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Expiry"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Status"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(411, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 20)
        Label6.TabIndex = 18
        Label6.Text = "Search..."
        ' 
        ' text_search
        ' 
        text_search.Location = New Point(402, 50)
        text_search.Name = "text_search"
        text_search.Size = New Size(317, 27)
        text_search.TabIndex = 17
        ' 
        ' product_status
        ' 
        product_status.AutoSize = True
        product_status.Location = New Point(86, 433)
        product_status.Name = "product_status"
        product_status.Size = New Size(93, 24)
        product_status.TabIndex = 19
        product_status.Text = "Available"
        product_status.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 917)
        Controls.Add(product_status)
        Controls.Add(Label6)
        Controls.Add(text_search)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(product_group)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_update)
        Controls.Add(btn_delete)
        Controls.Add(btn_clear)
        Controls.Add(btn_save)
        Controls.Add(product_expiry)
        Controls.Add(product_name)
        Controls.Add(product_price)
        Controls.Add(product_no)
        Name = "Form1"
        Text = "CRUD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents product_no As TextBox
    Friend WithEvents product_price As TextBox
    Friend WithEvents product_name As TextBox
    Friend WithEvents product_expiry As DateTimePicker
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents product_group As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents text_search As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
    Friend WithEvents product_status As CheckBox

End Class
