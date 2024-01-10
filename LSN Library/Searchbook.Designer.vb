<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Searchbook
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Searchbook))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SantoDataSet10 = New LSN_Library.santoDataSet10()
        Me.BookinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookinfoTableAdapter = New LSN_Library.santoDataSet10TableAdapters.bookinfoTableAdapter()
        Me.AccessionNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookAuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SantoDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-20, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 110)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(157, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Book form Library Data Base"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(100, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 26)
        Me.Panel3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Book Accession No."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(100, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 26)
        Me.Panel2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Book Title"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(100, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 26)
        Me.Panel4.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Book Author"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "(OR)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(174, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "(OR)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(337, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(337, 192)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(145, 20)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(337, 246)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(145, 20)
        Me.TextBox3.TabIndex = 25
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(488, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 62)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Search by No"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(488, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 62)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Search by Title"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(488, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 62)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Search by Author"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(658, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 46)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(658, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 46)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccessionNoDataGridViewTextBoxColumn, Me.BookTitleDataGridViewTextBoxColumn, Me.BookAuthorDataGridViewTextBoxColumn, Me.EditionDataGridViewTextBoxColumn, Me.BDateDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.VendorDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookinfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(779, 150)
        Me.DataGridView1.TabIndex = 31
        '
        'SantoDataSet10
        '
        Me.SantoDataSet10.DataSetName = "santoDataSet10"
        Me.SantoDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookinfoBindingSource
        '
        Me.BookinfoBindingSource.DataMember = "bookinfo"
        Me.BookinfoBindingSource.DataSource = Me.SantoDataSet10
        '
        'BookinfoTableAdapter
        '
        Me.BookinfoTableAdapter.ClearBeforeFill = True
        '
        'AccessionNoDataGridViewTextBoxColumn
        '
        Me.AccessionNoDataGridViewTextBoxColumn.DataPropertyName = "AccessionNo"
        Me.AccessionNoDataGridViewTextBoxColumn.HeaderText = "AccessionNo"
        Me.AccessionNoDataGridViewTextBoxColumn.Name = "AccessionNoDataGridViewTextBoxColumn"
        '
        'BookTitleDataGridViewTextBoxColumn
        '
        Me.BookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle"
        Me.BookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle"
        Me.BookTitleDataGridViewTextBoxColumn.Name = "BookTitleDataGridViewTextBoxColumn"
        '
        'BookAuthorDataGridViewTextBoxColumn
        '
        Me.BookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor"
        Me.BookAuthorDataGridViewTextBoxColumn.HeaderText = "BookAuthor"
        Me.BookAuthorDataGridViewTextBoxColumn.Name = "BookAuthorDataGridViewTextBoxColumn"
        '
        'EditionDataGridViewTextBoxColumn
        '
        Me.EditionDataGridViewTextBoxColumn.DataPropertyName = "Edition"
        Me.EditionDataGridViewTextBoxColumn.HeaderText = "Edition"
        Me.EditionDataGridViewTextBoxColumn.Name = "EditionDataGridViewTextBoxColumn"
        '
        'BDateDataGridViewTextBoxColumn
        '
        Me.BDateDataGridViewTextBoxColumn.DataPropertyName = "BDate"
        Me.BDateDataGridViewTextBoxColumn.HeaderText = "BDate"
        Me.BDateDataGridViewTextBoxColumn.Name = "BDateDataGridViewTextBoxColumn"
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        '
        'VendorDataGridViewTextBoxColumn
        '
        Me.VendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.Name = "VendorDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'Searchbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Searchbook"
        Me.Text = "Searchbook"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SantoDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SantoDataSet10 As santoDataSet10
    Friend WithEvents BookinfoBindingSource As BindingSource
    Friend WithEvents BookinfoTableAdapter As santoDataSet10TableAdapters.bookinfoTableAdapter
    Friend WithEvents AccessionNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookAuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
