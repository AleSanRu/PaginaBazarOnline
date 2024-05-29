<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestraInicio.Master" AutoEventWireup="true" CodeBehind="MostrarProductos.aspx.cs" Inherits="WABazarHub.FormulariosWeb.MostrarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <style>
        .card {
            border: none;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            transition: box-shadow 0.3s ease;
        }

            .card:hover {
                box-shadow: 0 8px 12px rgba(0, 0, 0, 0.1);
            }

        .card-body {
            padding: 20px;
        }

        .card-title {
            font-size: 1.5rem;
            font-weight: bold;
            margin-bottom: 10px;
            color: black; /* Color del texto negro */
        }

        .card-text {
            font-size: 1rem;
            color: #555;
            margin-bottom: 15px;
        }

        .card-price {
            font-size: 1.2rem;
            font-weight: bold;
            color: #ff6b6b; /* Color para el precio */
            margin-bottom: 5px;
        }

        .card-stock {
            font-size: 1rem;
            color: #777;
        }

        .card .image-container {
            width: 100%;
            height: 200px; /* Tamaño deseado para las imágenes */
            overflow: hidden;
        }

            .card .image-container img {
                width: 100%;
                height: auto;
                border: 1px solid #ddd; /* Borde para las imágenes */
                border-radius: 5px; /* Bordes redondeados */
            }

        .input-group.mb-3 {
            margin-bottom: 20px;
        }

        .btn-group-vertical.w-100 {
            margin-bottom: 20px;
        }

        /*valoracion*/
        .rating-section {
            margin-top: 20px;
            text-align: center;
            color: black;
        }

        .rating-container {
            position: relative;
            display: inline-block;
        }

        .rating-stars {
            position: relative;
        }

        .rating-numbers {
            position: absolute;
            width: 100%;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            display: flex;
            justify-content: space-between;
        }

            .rating-numbers span {
                width: 20px;
                height: 20px;
                line-height: 20px;
                text-align: center;
                border-radius: 50%;
                background-color: #fff;
            }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Listado de Productos</h2>

    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="input-group mb-3">
                    <asp:TextBox ID="txtBuscarProductos" runat="server" CssClass="form-control" placeholder="Buscar productos..."></asp:TextBox>
                    <div class="input-group-append">
                        <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-primary" Text="Buscar" OnClick="btnBuscar_Click" />
                    </div>
                </div>

                <div class="input-group mb-3">
                    <asp:TextBox ID="txtCostoMinimo" runat="server" CssClass="form-control" placeholder="Costo mínimo" TextMode="Number"></asp:TextBox>
                    <div class="input-group-prepend">
                        <span class="input-group-text">-</span>
                    </div>
                    <asp:TextBox ID="txtCostoMaximo" runat="server" CssClass="form-control" placeholder="Costo máximo" TextMode="Number"></asp:TextBox>
                </div>

                <div class="input-group mb-3">
                    <asp:TextBox ID="txtProveedor" runat="server" CssClass="form-control" placeholder="Nombre del proveedor"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>

    <asp:Label ID="lblMensaje" runat="server" CssClass="alert alert-warning" Visible="false"></asp:Label>
    <div class="row">
        <asp:Repeater ID="rptProductos" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="card mb-4">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <p class="card-text"><strong>Descripcion: </strong><%# Eval("Descripcion") %></p>
                            <p class="card-text"><strong>Precio: </strong><%# Eval("Precio", "{0:C}") %></p>
                            <p class="card-text"><strong>Stock: </strong><%# Eval("Stock") %></p>
                            <p class="card-text"><strong>Proveedor: </strong><%# ObtenerNombreProveedor(Eval("ProveedorID")) %></p>
                            <div class="image-container">
                                <img src='<%# GetImagePath(Eval("ProductoID")) %>' alt='<%# Eval("Nombre") %>' class="card-image" />
                            </div>
                            <!-- Sección de comentarios -->
                            <div class="comment-section">
                                <h6>Comentarios:</h6>
                                <!-- Aquí puedes agregar un control para mostrar los comentarios -->
                            </div>

                            <div class="rating-section">
                                <h6>Valoración:</h6>
                                <div class="rating-container">
                                    <div class="rating-stars">
                                        <input text="1" type="radio" id="star5" name="rating" value="5" />
                                        <label for="star5"></label>
                                        <input type="radio" id="star4" name="rating" value="4" />
                                        <label for="star4"></label>
                                        <input type="radio" id="star3" name="rating" value="3" />
                                        <label for="star3"></label>
                                        <input type="radio" id="star2" name="rating" value="2" />
                                        <label for="star2"></label>
                                        <input type="radio" id="star1" name="rating" value="1" />
                                        <label for="star1"></label>
                                    </div>
                                 
                                </div>
                            </div>


                            <asp:Button ID="btnSumar" runat="server" Text="Agregar al carrito" CssClass="btn btn-primary" CommandName="Sumar" CommandArgument='<%# Eval("ProductoID") %>' OnClick="btnSumar_Click" />
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar del carrito" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("ProductoID") %>' OnClick="btnEliminar_Click" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <script>
        // Función para almacenar la posición de la página
        function guardarPosicion() {
            var scrollPosition = window.scrollY || window.pageYOffset;
            sessionStorage.setItem('scrollPosition', scrollPosition);
        }

        // Llamar a la función para guardar la posición antes de recargar la página
        window.onbeforeunload = guardarPosicion;
    </script>
</asp:Content>
