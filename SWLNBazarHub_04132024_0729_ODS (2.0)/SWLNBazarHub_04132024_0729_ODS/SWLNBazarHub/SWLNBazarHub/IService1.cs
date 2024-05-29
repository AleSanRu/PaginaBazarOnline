using SWLNBazarHub.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SWLNBazarHub
{
    [ServiceContract]
    public interface IService1
    {
        #region Usuarios

        [OperationContract]
        void InsertarUsuario(EUsuario usuario);

        [OperationContract]
        void ActualizarUsuario(EUsuario usuario);

        [OperationContract]
        void ActualizarUsuarioEstado(int usuarioID, string estado);

        [OperationContract]
        void ActualizarUsuarioFechaEdicion(int usuarioID, DateTime fechaEdicion);

        [OperationContract]
        List<EUsuario> ObtenerTodosUsuarios();

        #endregion

        #region TipoUsuario

        [OperationContract]
        void InsertarTipoUsuario(ETipoUsuario tipoUsuario);

        [OperationContract]
        void ActualizarTipoUsuario(ETipoUsuario tipoUsuario);

        [OperationContract]
        void ActualizarTipoUsuarioEstado(int tipoUsuarioID, string estado);

        [OperationContract]
        void ActualizarTipoUsuarioFechaEdicion(int tipoUsuarioID, DateTime fechaEdicion);

        [OperationContract]
        List<ETipoUsuario> ObtenerTodosTiposUsuario();

        #endregion

        #region Productos

        [OperationContract]
        void InsertarProducto(EProductos producto);

        [OperationContract]
        void ActualizarProducto(EProductos producto);

        [OperationContract]
        void ActualizarProductoEstado(int productoID, string estado);

        [OperationContract]
        void ActualizarProductoFechaEdicion(int productoID, DateTime fechaEdicion);

        [OperationContract]
        List<EProductos> ObtenerTodosProductos();

        #endregion

        #region Pedidos

        [OperationContract]
        void InsertarPedido(EPedidos pedido);

        [OperationContract]
        void ActualizarPedido(EPedidos pedido);

        [OperationContract]
        void ActualizarPedidoEstado(int pedidoID, string estado);

        [OperationContract]
        void ActualizarPedidoFechaEdicion(int pedidoID, DateTime fechaEdicion);

        [OperationContract]
        List<EPedidos> ObtenerTodosPedidos();

        #endregion

        #region DetallesPedido

        [OperationContract]
        void InsertarDetallePedido(EDetallesPedido detallePedido);

        [OperationContract]
        void ActualizarDetallePedido(EDetallesPedido detallePedido);

        [OperationContract]
        void ActualizarDetallePedidoEstado(int detalleID, string estado);

        [OperationContract]
        void ActualizarDetallePedidoFechaEdicion(int detalleID, DateTime fechaEdicion);

        [OperationContract]
        List<EDetallesPedido> ObtenerTodosDetallesPedidos();

        #endregion

        #region DireccionesEnvio

        [OperationContract]
        void InsertarDireccionEnvio(EDireccionesEnvio direccionEnvio);

        [OperationContract]
        void ActualizarDireccionEnvio(EDireccionesEnvio direccionEnvio);

        [OperationContract]
        void ActualizarDireccionEnvioEstado(int direccionID, string estado);

        [OperationContract]
        void ActualizarDireccionEnvioFechaEdicion(int direccionID, DateTime fechaEdicion);

        [OperationContract]
        List<EDireccionesEnvio> ObtenerTodasDireccionesEnvio();

        #endregion

        #region Proveedores

        [OperationContract]
        void InsertarProveedor(EProveedores proveedor);

        [OperationContract]
        void ActualizarProveedor(EProveedores proveedor);

        [OperationContract]
        void ActualizarProveedorEstado(int proveedorID, string estado);

        [OperationContract]
        void ActualizarProveedorFechaEdicion(int proveedorID, DateTime fechaEdicion);

        [OperationContract]
        List<EProveedores> ObtenerTodosProveedores();

        #endregion

        #region Categorias

        [OperationContract]
        void InsertarCategoria(ECategorias categoria);

        [OperationContract]
        void ActualizarCategoria(ECategorias categoria);

        [OperationContract]
        void ActualizarCategoriaEstado(int categoriaID, string estado);

        [OperationContract]
        void ActualizarCategoriaFechaEdicion(int categoriaID, DateTime fechaEdicion);

        [OperationContract]
        List<ECategorias> ObtenerTodasCategorias();

        #endregion
    }
}
