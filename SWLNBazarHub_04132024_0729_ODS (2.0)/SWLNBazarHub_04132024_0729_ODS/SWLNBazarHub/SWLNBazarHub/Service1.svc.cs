using SWLNBazarHub.Controladoras;
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
    public class Service1 : IService1
    {
        #region Variables
        CCategorias cCategorias = new CCategorias();
        CDireccionesEnvio cDireccionesEnvio = new CDireccionesEnvio();
        CPedidos cPedidos = new CPedidos();
        CProvedorees cProveedores = new CProvedorees();
        CUsuario cUsuario = new CUsuario();
        DetallesPedido cDetallesPedido = new DetallesPedido();
        Productos cProductos = new Productos();
        TipoUsuario cTipoUsuarios = new TipoUsuario();
        #endregion
         #region Usuarios
        public void InsertarUsuario(EUsuario usuario)
        {
            cUsuario.InsertarUsuario(usuario);
        }

        public void ActualizarUsuario(EUsuario usuario)
        {
            cUsuario.ActualizarUsuario(usuario);
        }

        public void ActualizarUsuarioEstado(int usuarioID, string estado)
        {
            cUsuario.ActualizarEstadoUsuario(usuarioID, estado);
        }

        public void ActualizarUsuarioFechaEdicion(int usuarioID, DateTime fechaEdicion)
        {
            cUsuario.ActualizarFechaEdicionUsuario(usuarioID, fechaEdicion);
        }

        public List<EUsuario> ObtenerTodosUsuarios()
        {
            return cUsuario.ObtenerTodosUsuarios().ToList();
        }

        #endregion
        #region TipoUsuario

        public void InsertarTipoUsuario(ETipoUsuario tipoUsuario)
        {
            cTipoUsuarios.InsertarTipoUsuario(tipoUsuario);
        }

        public void ActualizarTipoUsuario(ETipoUsuario tipoUsuario)
        {
            cTipoUsuarios.ActualizarTipoUsuario(tipoUsuario);
        }

        public void ActualizarTipoUsuarioEstado(int tipoUsuarioID, string estado)
        {
            cTipoUsuarios.ActualizarEstadoTipoUsuario(tipoUsuarioID, estado);
        }

        public void ActualizarTipoUsuarioFechaEdicion(int tipoUsuarioID, DateTime fechaEdicion)
        {
            cTipoUsuarios.ActualizarFechaEdicionTipoUsuario(tipoUsuarioID, fechaEdicion);
        }

        public List<ETipoUsuario> ObtenerTodosTiposUsuario()
        {
            return cTipoUsuarios.ObtenerTodosTipoUsuario().ToList();
        }

        #endregion
        #region Productos

        public void InsertarProducto(EProductos producto)
        {
            cProductos.InsertarProducto(producto);
        }

        public void ActualizarProducto(EProductos producto)
        {
            cProductos.ActualizarProducto(producto);
        }

        public void ActualizarProductoEstado(int productoID, string estado)
        {
            cProductos.ActualizarEstadoProducto(productoID, estado);
        }

        public void ActualizarProductoFechaEdicion(int productoID, DateTime fechaEdicion)
        {
            cProductos.ActualizarFechaEdicionProducto(productoID, fechaEdicion);
        }

        public List<EProductos> ObtenerTodosProductos()
        {
            return cProductos.ObtenerTodosProductos().ToList();
        }

        #endregion
        #region Pedidos

        public void InsertarPedido(EPedidos pedido)
        {
            cPedidos.AgregarPedido(pedido);
        }

        public void ActualizarPedido(EPedidos pedido)
        {
            cPedidos.ActualizarPedido(pedido);
        }

        public void ActualizarPedidoEstado(int pedidoID, string estado)
        {
            cPedidos.ActualizarEstadoPedido(pedidoID, estado);
        }

        public void ActualizarPedidoFechaEdicion(int pedidoID, DateTime fechaEdicion)
        {
            cPedidos.ActualizarFechaEdicionPedido(pedidoID, fechaEdicion);
        }

        public List<EPedidos> ObtenerTodosPedidos()
        {
            return cPedidos.ObtenerTodosPedidos().ToList();
        }

        #endregion
        #region DetallesPedido

        public void InsertarDetallePedido(EDetallesPedido detallePedido)
        {
            cDetallesPedido.InsertarDetallePedido(detallePedido);
        }

        public void ActualizarDetallePedido(EDetallesPedido detallePedido)
        {
            cDetallesPedido.ActualizarDetallePedido(detallePedido);
        }

        public void ActualizarDetallePedidoEstado(int detalleID, string estado)
        {
            cDetallesPedido.ActualizarEstadoDetallePedido(detalleID, estado);
        }

        public void ActualizarDetallePedidoFechaEdicion(int detalleID, DateTime fechaEdicion)
        {
            cDetallesPedido.ActualizarFechaEdicionDetallePedido(detalleID, fechaEdicion);
        }

        public List<EDetallesPedido> ObtenerTodosDetallesPedidos()
        {
            return cDetallesPedido.ObtenerTodosDetallesPedidos().ToList();
        }

        #endregion
        #region DireccionesEnvio

        public void InsertarDireccionEnvio(EDireccionesEnvio direccionEnvio)
        {
            cDireccionesEnvio.InsertarDireccionEnvio(direccionEnvio);
        }

        public void ActualizarDireccionEnvio(EDireccionesEnvio direccionEnvio)
        {
            cDireccionesEnvio.ActualizarDireccionEnvio(direccionEnvio);
        }

        public void ActualizarDireccionEnvioEstado(int direccionID, string estado)
        {
            cDireccionesEnvio.ActualizarEstadoDireccionEnvio(direccionID, estado);
        }

        public void ActualizarDireccionEnvioFechaEdicion(int direccionID, DateTime fechaEdicion)
        {
            cDireccionesEnvio.ActualizarFechaEdicionDireccionEnvio(direccionID, fechaEdicion);
        }

        public List<EDireccionesEnvio> ObtenerTodasDireccionesEnvio()
        {
            return cDireccionesEnvio.ObtenerTodasDireccionesEnvio().ToList();
        }

        #endregion
        #region Proveedores

        public void InsertarProveedor(EProveedores proveedor)
        {
            cProveedores.AgregarProveedor(proveedor);
        }

        public void ActualizarProveedor(EProveedores proveedor)
        {
            cProveedores.ActualizarProveedor(proveedor);
        }

        public void ActualizarProveedorEstado(int proveedorID, string estado)
        {
            cProveedores.ActualizarEstadoProveedor(proveedorID, estado);
        }

        public void ActualizarProveedorFechaEdicion(int proveedorID, DateTime fechaEdicion)
        {
            cProveedores.ActualizarFechaEdicionProveedor(proveedorID, fechaEdicion);
        }

        public List<EProveedores> ObtenerTodosProveedores()
        {
            return cProveedores.ObtenerTodosProveedores().ToList();
        }

        #endregion
        #region Categorias

        public void InsertarCategoria(ECategorias categoria)
        {
            cCategorias.AgregarCategoria(categoria);
        }

        public void ActualizarCategoria(ECategorias categoria)
        {
            cCategorias.ActualizarCategoria(categoria);
        }

        public void ActualizarCategoriaEstado(int categoriaID, string estado)
        {
            cCategorias.ActualizarEstadoCategoria(categoriaID, estado);
        }

        public void ActualizarCategoriaFechaEdicion(int categoriaID, DateTime fechaEdicion)
        {
            cCategorias.ActualizarFechaEdicionCategoria(categoriaID, fechaEdicion);
        }

        public List<ECategorias> ObtenerTodasCategorias()
        {
            return cCategorias.ObtenerTodasCategorias().ToList();
        }

        #endregion
    }
}
