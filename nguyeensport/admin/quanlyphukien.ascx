﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="quanlyphukien.ascx.cs" Inherits="nguyeensport.admin.quanlyphukien" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<!-- Page Heading -->
<h1 class="h3 mb-2 text-gray-800">Quản lý phụ kiện</h1>
<p class="mb-4">
        
</p>

<asp:MultiView ID="mlv" runat="server" ActiveViewIndex="0">
    <asp:View ID="v1" runat="server">
        <!-- DataTales Example -->
        <div class="card shadow mb-4">
    <div class="card-header py-3">
        <asp:Button ID="btnAdd" CssClass="btn btn-outline-danger btn-sm" Text="Thêm sản phẩm" runat="server" OnClick="btnAdd_Click" />
    </div>
    <div class="card-body">
         <div class="dvProgressBar" style=" visibility:hidden;position: fixed; text-align: center; height: 100%; width: 100%; top: 0; right: 0; left: 0; z-index: 9999999; background-color: #000000; opacity: 0.84;">
                      <div class="position-relative"  style="width: 100%;height: 100%;">
                         <img src="/images/common/NGUYEEN-White.svg" style="width: 100px; position:absolute;top:50%;left:50%; height: 100px;margin:0;"/>      
                         <div class="spinner-border" style="width: 100px; height: 100px; position:absolute;top:50%;left:50%;" role="status"></div>
                      </div>
          </div>
        <div class="table-responsive">
            <asp:Repeater ID="rptListProduct" runat="server" OnItemDataBound="rptListProduct_ItemDataBound" OnItemCommand="rptListProduct_ItemCommand">
                <HeaderTemplate>
                    <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                <thead>
                    <tr>
                        <th style="width:80px;">Hình ảnh</th>
                        <th>Tên sản phẩm</th>
                        <th style="width:60px;">Hiển thị</th>
                        <th style="width:60px;">Active</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:HiddenField ID="maSanPham" runat="server" Value='<%#: Eval("maSanPham") %>' />
                    <asp:HiddenField ID="idSanPham" runat="server" Value= '<%#: Eval("id") %>'/>
                     <tr>
                       <td style="width:120px;">
                           <figure>
                              <img src="<%#: nguyeensport.dal.clsThuVien.uploadImagePorcess((Eval("avatarSanPham").ToString()),Eval("avatarSanPham").ToString(),123,123) %>" alt="<%#: Eval("tenSanPham") %>" loading="lazy" />
                           </figure>
                       </td>
                      <td>
                           <div class="p-2">
                               <a href="/<%#: Eval("linkSanPham")+"-"+Eval("maSanPham") %>" class="font-weight-bold text-dark text-lg"><%#: Eval("tenSanPham") %></a>
                               <div class="row">
                                   <div class="col-6">
                                       <div class="text-secondary">ID: <strong><%#: Eval("maSanPham") %></strong></div>
                                       <div class="text-secondary">Loại sản phẩm: <%#: Eval("productType") %></div>
                                        <div class="text-secondary">Thương hiệu: <%#: Eval("brands") %></div>
                                       <div class="text-secondary">Giá: <strong><i><%#: string.Format("{0:N0}",Eval("giaOutput")) %> </i><small>VNĐ</small></strong> <del><asp:Label ID="lblDiscount" runat="server" Text ='<%#: string.Format("{0:N0}",Eval("giaInput")) + " VNĐ" %>'></asp:Label></del> <asp:Label ID="lblSaving" runat="server" Text ='<%#: "Giảm " + string.Format("{0:N0}",int.Parse(Eval("giaInput").ToString()) - int.Parse(Eval("giaOutput").ToString())) %>'></asp:Label></div>
                                   </div>
                                   <div class="col-6">
                                        <div class="text-secondary">Size: 
                                           <asp:Repeater ID="rptProductSize" runat="server">
                                               <ItemTemplate>
                                                   <div class="btn btn-sm btn-outline-danger" data-bs-toggle="tooltip" data-bs-html="true" title='Tồn kho: <%#:Eval("soLuong") %> sản phẩm'><%#: Eval("tenSize") %></div>
                                               </ItemTemplate>
                                           </asp:Repeater>
                                       </div>
                                       <div class="text-dark mt-1">Tổng số lượng: <span><asp:Literal ID="ltTongSoLuong" runat="server"></asp:Literal></span></div>
                                   </div>
                               </div>
                              
                           </div>
                       </td>
                       <td class="p-2 text-secondary">
                           <asp:CheckBox ID="cbkHienThi" runat="server" Text='<%#: Eval("hienThi") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="cbkHienThi_CheckedChanged" OnLoad="cbkHienThi_Load"/>  
                       </td>
                       <td class="p-2 text-secondary">
                           <asp:CheckBox ID="cbkActive" runat="server" Text='<%#: Eval("Active") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="cbkActive_CheckedChanged" OnLoad="cbkActive_Load"/>  
                       </td>
                       <td class="p-2" style="width:120px;"><asp:LinkButton ID="btnSua" runat="server" CommandName="update" CommandArgument='<%#: Eval("maSanPham")%>' CssClass="text-danger"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil-square" viewBox="0 0 16 16">
  <path d="M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"/>
  <path fill-rule="evenodd" d="M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"/>
</svg> Sửa</asp:LinkButton> | <asp:LinkButton ID="btnXoa" runat="server" CommandName="delete" CommandArgument='<%#: Eval("maSanPham")%>' OnClientClick="javascript:ShowProgressBar()" OnLoad="btnXoa_Load" CssClass="text-danger"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
  <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
  <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
</svg> Xóa</asp:LinkButton> </td>
                   </tr>
                </ItemTemplate>
                <FooterTemplate>
                           
                </tbody>
            </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</div>
    </asp:View>
    <asp:View ID="v2" runat="server">
            <asp:HiddenField ID="hdInsert" runat="server" />
            <asp:HiddenField ID="hdId_FB" runat="server" />
            <asp:HiddenField ID="hdImage1" runat="server" />
            <asp:HiddenField ID="hdImage2" runat="server" />
            <asp:HiddenField ID="hdImage3" runat="server" />
            <asp:HiddenField ID="hdImage4" runat="server" />
            <asp:HiddenField ID="hdImage5" runat="server" />
            <asp:HiddenField ID="hdImage6" runat="server" />
            <asp:HiddenField ID="hdImage7" runat="server" />
            <asp:HiddenField ID="hdImage8" runat="server" />
            <asp:HiddenField ID="hdImage9" runat="server" />
            <asp:HiddenField ID="hdImage10" runat="server" />
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <asp:Button ID="btnBack" CssClass="btn btn-outline-dark btn-sm" Text="Quay lại" runat="server" OnClick="btnBack_Click"/>
                </div>
                <div class="card-body card-body-scroll">
                    <div class="row">
                        <div class="col-2">
                             <div class="form-group">
                                  <asp:TextBox ID="txtMaSanPham" CssClass="form-control" runat="server" placeholder="Mã sản phẩm"></asp:TextBox>
                                  <asp:Label ID="lblMaSanPham" runat="server"></asp:Label>
                             </div>
                        </div>
                        <div class="col-10">
                             <div class="form-group">
                                 <asp:TextBox ID="txtTenSanPham" CssClass="form-control" runat="server" placeholder="Tên sản phẩm"></asp:TextBox>
                                 <asp:Label ID="Label1" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                             <div class="form-group">
                                 <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server" placeholder="Nhập tiêu đề"></asp:TextBox>
                                 <asp:Label ID="Label2" runat="server"></asp:Label>
                                
                            </div>
                        </div>
                    </div>
                    <div class="row">
                          <div class="col-6">
                             <div class="form-group">
                                 <asp:TextBox ID="txtMetaKeywork" CssClass="form-control" runat="server" placeholder="Nhập keywork" TextMode="MultiLine"></asp:TextBox>
                                 <asp:Label ID="Label3" runat="server"></asp:Label>
                            </div>
                        </div>
                         <div class="col-6">
                             <div class="form-group">
                                 <asp:TextBox ID="txtMetaDescription" CssClass="form-control" runat="server" placeholder="Nhập description" TextMode="MultiLine"></asp:TextBox>
                                 <asp:Label ID="Label4" runat="server"></asp:Label>
                            </div>
                        </div>
                     </div>
                     <div class="row">
                        <div class="col-12">
                             <div class="row mb-3 d-flex">
                                <div class="col-2">
                                         <div class="form-group">
                                             <asp:TextBox ID="txtGia" runat="server" CssClass="form-control form-control-sm" placeholder="Giá"></asp:TextBox>
                                         </div>
                                    </div>
                                <div class="col-2">
                                         <div class="form-group">
                                            <div class="ui-dropdownlist">
                                            <asp:DropDownList ID="drDiscount" runat="server" CssClass="form-control form-control-sm">
                                                <asp:ListItem Value="">Chọn discount</asp:ListItem>
                                                <asp:ListItem Value="0">New</asp:ListItem>
                                                <asp:ListItem Value="00">Pre-Order</asp:ListItem>
                                                <asp:ListItem Value="000">0%</asp:ListItem>
                                                <asp:ListItem Value="0.05">5%</asp:ListItem>
                                                <asp:ListItem Value="0.1">10%</asp:ListItem>
                                                <asp:ListItem Value="0.2">20%</asp:ListItem>
                                                <asp:ListItem Value="0.3">30%</asp:ListItem>
                                                <asp:ListItem Value="0.35">35%</asp:ListItem>
                                                <asp:ListItem Value="0.5">50%</asp:ListItem>
                                            </asp:DropDownList>
                                            </div>
                                         </div>
                                    </div>
                               
                            </div>                         
                        </div>
                    </div>
                    <div class="row">
                    <div class="col-6">
                        <table class="table text-dark">
                      <thead>
                        <tr>
                          <th scope="col">#</th>
                          <th scope="col">Tên size</th>
                          <th scope="col">Số lượng</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <th scope="row">1</th>
                          <td> <asp:Label ID="lblS" runat="server" Text="S"></asp:Label></td>
                          <td><asp:TextBox ID="txtS" runat="server" CssClass="form-control form-control-sm"></asp:TextBox></td>
                        </tr>
                        <tr>
                          <th scope="row">2</th>
                          <td><asp:Label ID="lblM" runat="server" Text="M"></asp:Label></td>
                          <td><asp:TextBox ID="txtM" runat="server" CssClass="form-control form-control-sm"></asp:TextBox></td>
                        </tr>
                        <tr>
                          <th scope="row">3</th>
                          <td><asp:Label ID="lblL" runat="server" Text="L"></asp:Label></td>
                          <td><asp:TextBox ID="txtL" runat="server" CssClass="form-control form-control-sm"></asp:TextBox></td>
                        </tr>
                          <tr>
                          <th scope="row">4</th>
                          <td><asp:Label ID="lblXL" runat="server" Text="XL"></asp:Label></td>
                          <td><asp:TextBox ID="txtXL" runat="server" CssClass="form-control form-control-sm"></asp:TextBox></td>
                        </tr>
                          <tr>
                          <th scope="row">5</th>
                          <td><asp:Label ID="lblXXL" runat="server" Text="XXL"></asp:Label></td>
                          <td><asp:TextBox ID="txtXXL" runat="server" CssClass="form-control form-control-sm"></asp:TextBox></td>
                        </tr>
                      </tbody>
                    </table>
                    </div>
                </div>
                    <div class="row">
                          <div class="col">
                              <div class="form-group">
                                    <asp:Label ID="lblBrands" runat="server" Text="Thương hiệu" CssClass="mb-2"></asp:Label>
                                    <div class="ui-dropdownlist">
                                        <asp:TextBox ID="txtBrands" runat="server" CssClass="form-control js-brands" placeholder="Chọn thương hiệu"></asp:TextBox>
                                   </div>
                                  
                                    <script>

                                        $(function () {

                                            $('.js-brands').autocomplete({
                                                source: function (request, response) {
                                                    $.ajax({
                                                        url: "/admin/Brands.ashx",
                                                        dataType: "json",
                                                        data: {
                                                            term: request.term
                                                        },
                                                        success: function (data) {

                                                            response($.map(data, function (item) {
                                                                return {
                                                                    tenBrands: item.tenBrands,
                                                                    avatarBrands: item.avatarBrands,
                                                                    join: item
                                                                }

                                                            }));
                                                        },
                                                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                                                            alert(textStatus);
                                                        }
                                                    });
                                                },
                                                minLength: 0,
                                                select: function (event, ui) {
                                                    $('.js-brands').val(ui.item.tenBrands);
                                                    return false;
                                                }
                                            }).focus(function () {
                                                $(this).autocomplete("search", "");
                                            }).data("ui-autocomplete")._renderItem = function (ul, item) {
                                                return $("<li>").append("<div><img class='ui-menu-item-image' src='" + item.avatarBrands + "' alt='" + item.tenBrands + "'/><span>" + item.tenBrands + "</span></div>").appendTo(ul);

                                            };

                                        });
                                    </script>
                              </div>
                        </div>
                        <div class="col">
                            <div class="form-group">
                                <asp:Label ID="lblProductType" runat="server" Text="Product Type" CssClass="mb-2"></asp:Label>
                                 <div class="ui-dropdownlist">
                                <asp:TextBox ID="txtProductType" runat="server" CssClass="form-control js-producttype" placeholder="Chọn loại sản phẩm"></asp:TextBox>
                                </div>
                                  <script>
                                      $(function () {
                                          $('.js-producttype').autocomplete({
                                              source: function (request, response) {
                                                  $.ajax({
                                                      url: "/admin/ProductType.ashx",
                                                      dataType: "json",
                                                      data: {
                                                          term: request.term
                                                      },
                                                      success: function (data) {

                                                          response($.map(data, function (item) {
                                                              return {
                                                                  tenProductType: item.tenProductType,
                                                                  iconProductType: item.iconProductType,
                                                                  join: item
                                                              }

                                                          }));
                                                      },
                                                      error: function (XMLHttpRequest, textStatus, errorThrown) {
                                                          alert(textStatus);
                                                      }
                                                  });
                                              },
                                              minLength: 0,
                                              select: function (event, ui) {
                                                  $('.js-producttype').val(ui.item.tenProductType);
                                                  return false;
                                              }
                                          }).focus(function () {
                                              $(this).autocomplete("search", "");
                                          }).data("ui-autocomplete")._renderItem = function (ul, item) {
                                              return $("<li>").append("<div><img class='ui-menu-item-image-icon' src='" + item.iconProductType + "' alt='" + item.tenProductType + "'/><span>" + item.tenProductType + "</span></div>").appendTo(ul);

                                          };

                                      });
                                  </script>
                            </div>
                        </div>
                        <div class="col">
                            <div class="form-group">
                                <asp:Label ID="lblProductSubType" runat="server" Text="Product Sub Type" CssClass="mb-2"></asp:Label>
                                <div class="ui-dropdownlist">
                                <asp:TextBox ID="txtdrSubType" runat="server" CssClass="form-control js-sub-type" placeholder="Chọn loại nhóm sản phẩm"></asp:TextBox>
                                </div>
                                  <script>
                                      $(function () {
                                          $('.js-sub-type').autocomplete({
                                              source: function (request, response) {
                                                  $.ajax({
                                                      url: "/admin/SubType.ashx",
                                                      dataType: "json",
                                                      data: {
                                                          term: request.term
                                                      },
                                                      success: function (data) {

                                                          response($.map(data, function (item) {
                                                              return {
                                                                  tenProductSubType: item.tenProductSubType,
                                                                  iconProductSubType: item.iconProductSubType,
                                                                  join: item
                                                              }

                                                          }));
                                                      },
                                                      error: function (XMLHttpRequest, textStatus, errorThrown) {
                                                          alert(textStatus);
                                                      }
                                                  });
                                              },
                                              minLength: 0,
                                              select: function (event, ui) {
                                                  $('.js-sub-type').val(ui.item.tenProductSubType);
                                                  return false;
                                              }
                                          }).focus(function () {
                                              $(this).autocomplete("search", "");
                                          }).data("ui-autocomplete")._renderItem = function (ul, item) {
                                              return $("<li>").append("<div><img class='ui-menu-item-image-icon' src='" + item.iconProductSubType + "' alt='" + item.tenProductSubType + "'/><span>" + item.tenProductSubType + "</span></div>").appendTo(ul);

                                          };

                                      });
                                  </script>
                            </div>
                        </div>
                         <div class="col">
                              <div class="form-group">
                                   <asp:Label ID="lblColor" runat="server" Text="Màu sắc" CssClass="mb-2"></asp:Label>
                                    <div class="ui-dropdownlist">
                                        <asp:TextBox ID="txtColor" runat="server" CssClass="form-control js-color" placeholder="Chọn màu sắc"></asp:TextBox>
                                    </div>
                                  
                                    <script>
                                        $(function () {
                                            $('.js-color').autocomplete({
                                                source: function (request, response) {
                                                    $.ajax({
                                                        url: "/admin/Color.ashx",
                                                        dataType: "json",
                                                        data: {
                                                            term: request.term
                                                        },
                                                        success: function (data) {

                                                            response($.map(data, function (item) {
                                                                return {
                                                                    tenColor: item.tenColor,
                                                                    join: item
                                                                }

                                                            }));
                                                        },
                                                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                                                            alert(textStatus);
                                                        }
                                                    });
                                                },
                                                minLength: 0,
                                                select: function (event, ui) {
                                                    $('.js-color').val(ui.item.tenColor);
                                                    return false;
                                                }
                                            }).focus(function () {
                                                $(this).autocomplete("search", "");
                                            }).data("ui-autocomplete")._renderItem = function (ul, item) {
                                                return $("<li>").append("<div><span class='collection-span'>" + item.tenColor + "</span></div>").appendTo(ul);

                                            };

                                        });
                                    </script>
                              </div>
                        </div>
                    </div>
                   
                    <div class="row">
                        <div class="col">
                            <span class="mb-2">Mô tả</span>
                            <dx:aspxhtmleditor ID="htmlEditor" runat="server" Width="100%" Theme="Default">
                                 <SettingsDialogs>
                                      <InsertImageDialog ShowMoreOptionsButton="false">
                                        <SettingsImageUpload>
                                            <FileSystemSettings UploadFolder="/images/anh-san-pham/" />
                                        </SettingsImageUpload>
                                    </InsertImageDialog>
                                    </SettingsDialogs>
                                    <Settings AllowInsertDirectImageUrls="false"></Settings>
                            </dx:aspxhtmleditor>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col d-flex flex-column mt-2">
                            <span>Avatar</span>
                            <asp:FileUpload ID="FileUpload1" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 1</span>
                            <asp:FileUpload ID="FileUpload2" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 2</span>
                            <asp:FileUpload ID="FileUpload3" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 3</span>
                            <asp:FileUpload ID="FileUpload4" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 4</span>
                            <asp:FileUpload ID="FileUpload5" runat="server"/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 5</span>
                            <asp:FileUpload ID="FileUpload7" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 6</span>
                            <asp:FileUpload ID="FileUpload8" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 7</span>
                            <asp:FileUpload ID="FileUpload9" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 8</span>
                            <asp:FileUpload ID="FileUpload10" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 9</span>
                            <asp:FileUpload ID="FileUpload11" runat="server"/>
                        </div>
                    </div>
                    <div class="row">
                         <div class="col-2 mt-2">
                            <span>Hiển thị</span>
                            <asp:CheckBox ID="cbkHienThi" runat="server" Text="Hiển thị" CssClass="custom-control custom-switch mt-3"/>
                        </div>
                        <div class="col-2 mt-2">
                            <span>Active</span>
                            <asp:CheckBox ID="cbkActive" runat="server" Text="Active" CssClass="custom-control custom-switch mt-3"/>
                        </div>
                        <div class="col mt-2 d-flex justify-content-end">
                            <asp:LinkButton ID="btnUpdate" runat="server" CssClass="btn btn-danger mt-4  position-relative" OnClick="btnUpdate_Click" OnClientClick="javascript:ShowProgressBar()" >
                                Update
                                  <div class="dvProgressBar" style="position:absolute;top:0;left:0px;background:#db1d24;display:block;width: 100%;height: 100%; visibility:hidden;">
                                    <div class="position-relative"  style="width: 100%;height: 100%;">
                                        <img src="/images/common/NGUYEEN-White.svg" style="width: 34px; height: 34px;margin:1px 0 0 2px;"/>      
                                        <div class="spinner-border" style="width: 35px; height: 35px; position:absolute;top:0.5px;left:22.5px;" role="status">
                                    </div>
                                  
                                </div>
                                </div>
                            </asp:LinkButton>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col mt-2">
                             <asp:Literal ID="lblThongBao2" runat="server" ></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
    </asp:View>
</asp:MultiView>