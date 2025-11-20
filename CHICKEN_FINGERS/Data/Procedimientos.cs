namespace CHICKEN_FINGERS.Data
{
    public class Procedimientos
    {
        public const string SP_VALIDAR_USUARIO = "sp_validar_usuario";

        public const string SP_AGREGAR_PRODUCTO = "sp_AgregarProducto";
        public const string SP_ELIMINAR_PRODUCTO = "sp_EliminarProducto";
        public const string SP_MODIFICAR_PRODUCTO = "sp_ModificarProducto";
        public const string SP_BUSCAR_PRODUCTO_POR_ID = "sp_BuscarProductoPorID";
        public const string SP_OBTENER_PRODUCTOS = "sp_ObtenerProductos";

        public const string SP_AGREGAR_CLIENTE = "sp_AgregarCliente";
        public const string SP_ELIMINAR_CLIENTE = "sp_EliminarCliente";
        public const string SP_MODIFICAR_CLIENTE = "sp_ModificarCliente";
        public const string SP_BUSCAR_CLIENTE_POR_ID = "sp_BuscarClientePorID";
        public const string SP_OBTENER_CLIENTES = "sp_ObtenerClientes";

        public const string SP_AGREGAR_METODO_PAGO = "sp_AgregarMetodoPago";
        public const string SP_ELIMINAR_METODO_PAGO = "sp_EliminarMetodoPago";
        public const string SP_MODIFICAR_METODO_PAGO = "sp_ModificarMetodoPago";
        public const string SP_BUSCAR_METODO_PAGO_POR_ID = "sp_BuscarMetodoPagoPorID";
        public const string SP_OBTENER_METODOS_PAGO = "sp_ObtenerMetodosPago";

        public const string SP_INSERTAR_CATEGORIA = "sp_InsertarCategoria";
        public const string SP_CATEGORIA_POR_ID = "sp_CategoriaPorId";
        public const string SP_ACTUALIZAR_CATEGORIA = "sp_ActualizarCategoria";
        public const string SP_ELIMINAR_CATEGORIA = "sp_EliminarCategoria";
        public const string SP_OBTENER_TODAS_CATEGORIAS = "sp_ObtenerTodasCategorias";

        public const string SP_INSERTAR_METODO_PAGO_PEDIDO = "sp_InsertarMetodoPagoPedido";
        public const string SP_ELIMINAR_METODO_PAGO_PEDIDO = "sp_EliminarMetodoPagoPedido";
        public const string SP_LISTAR_METODOS_PAGO_PEDIDO = "sp_ListarPedidoMetodoPago";
        public const string SP_OBTENER_METODOS_PAGO_PEDIDO_POR_ID = "sp_ObtenerPedidoMetodoPagoPorId";


        public const string SP_LISTAR_PEDIDOS = "sp_ListarPedidos";
        public const string SP_INSERTAR_PEDIDO = "sp_InsertarPedido";
        public const string SP_OBTENER_PEDIDOS_POR_ID = "sp_ObtenerPedidosPorId";
        public const string SP_ELIMINAR_PEDIDOS = "sp_EliminarPedidos";

        public const string SP_LISTAR_TARJETAS = "sp_ListarTarjetas";
        public const string SP_AGREGAR_TARJETA = "sp_AgregarTarjeta";
        public const string SP_AGREGAR_PUNTOS_TARJETAS = "sp_AgregarPuntosTarjetas";
        public const string SP_ELIMINAR_TARJETA = "sp_EliminarTarjeta";
        public const string SP_OBTENER_TARJETAS_POR_ID = "sp_ObtenerTarjetasPorId";

        public const string SP_LISTAR_PEDIDO_DETALLE = "sp_ListarPedidoDetalle";
        public const string SP_INSERTAR_PEDIDO_DETALLE = "sp_InsertarPedidoDetalle";
        public const string SP_OBTENER_PEDIDO_DETALLES_POR_ID = "sp_ObtenerPedidoDetallesPorId";
        public const string SP_ELIMINAR_PEDIDO_DETALLE = "sp_EliminarPedidoDetalle";
    }
}