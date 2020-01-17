Public Class vcliente
    Dim idcliente As Integer
    Dim nombres, apellidos, direccion, telefono, cedula As String

    'seeter  y getter metodo para leer y escribir datos

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gcedula
        Get
            Return cedula
        End Get
        Set(ByVal value)
            cedula = value
        End Set
    End Property



    'constructores recibiran todos los datos y se comunican con la carpeta datos

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal cedula As String)
        gidcliente = idcliente
        gnombres = nombres
        gapellidos = apellidos
        gdireccion = direccion
        gtelefono = telefono
        gcedula = cedula
    End Sub

End Class
