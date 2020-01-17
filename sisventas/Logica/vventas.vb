Public Class vventas

    Dim idventa, idcliente As Integer
    Dim fecha_venta As Date
    Dim tipo_documento, numero_documento As String

    Public Property gidventa
        Get
            Return idventa
        End Get
        Set(value)
            idventa = value
        End Set
    End Property

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value
        End Set
    End Property

    Public Property gfecha_venta
        Get
            Return fecha_venta
        End Get
        Set(value)
            fecha_venta = value
        End Set
    End Property

    Public Property gtipo_documento
        Get
            Return tipo_documento
        End Get
        Set(value)
            tipo_documento = value
        End Set
    End Property

    Public Property gnumero_documento
        Get
            Return numero_documento
        End Get
        Set(value)
            numero_documento = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idventa As Integer, ByVal idcliente As Integer, ByVal fecha_venta As Date, ByVal tipo_documento As String, ByVal numero_documento As String)

        gidventa = idventa
        gidcliente = idcliente
        gfecha_venta = fecha_venta
        gtipo_documento = tipo_documento
        gnumero_documento = numero_documento

    End Sub

End Class
