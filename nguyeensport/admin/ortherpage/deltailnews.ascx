<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="deltailnews.ascx.cs" Inherits="nguyeensport.admin.ortherpage.deltailnews" %>
<%@ Register Assembly="DevExpress.Web.v19.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<h1 class="h3 mb-2 text-gray-800">Quản lý tin tức</h1>


<asp:MultiView ID="mlv" runat="server" ActiveViewIndex="0">
    <asp:View ID="v1" runat="server">
        <!-- DataTales Example -->
        <div class="card shadow mb-4">
    <div class="card-header py-3">
       
        <asp:Button ID="btnAdd" CssClass="btn btn-outline-danger btn-sm " Text="Thêm tin tức" runat="server" OnClick="btnAdd_Click" />
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
                        <th style="width:80px;" >Hình ảnh</th>
                        <th >Tên tin tức</th>
                        <th style="width:535px;">Nội dung</th>
                        <th style="width:60px;">Lượt xem</th>
                        <th style="width:60px;">Ngày tạo</th>
                        <th style="width:60px;">Hiển thị</th>
                        <th style="width:60px;">Đã xóa</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:HiddenField ID="maNewsDeltail" runat="server" Value='<%#: Eval("maNewsDeltail") %>' />
                     <tr>
                       <td style="width:120px;">
                           <figure>
                               <img src="<%#: Eval("avatarNewsDeltail") %>"  alt='<%#: Eval("tenNewsDeltail") %>'/>
                           </figure>
                       </td>
                       <td>
                           <div class="p-2">
                               <a href="/tin-tuc/<%#:Eval("linkNews") +"/"+ Eval("linkNewsDeltail") %>" class="font-weight-bold text-dark text-lg" target="_blank"><%#: Eval("tenNewsDeltail") %></a>
                           </div>
                       </td>
                       <td class="text-secondary" style="width:535px;">
                           <div class="scrollable">
                               <%# DataBinder.Eval(Container.DataItem,"noiDung") %>
                           </div>
                       </td>
                       <td class="p-2 text-secondary"><%#: Eval("luotView") %></td>
                       <td class="p-2 text-secondary"><%#: DateTime.Parse(Eval("ngayTao").ToString()).ToString("dd/MM/yyyy") %></td>

                       <td class="p-2 text-secondary">
                           <asp:CheckBox ID="ckbHienThi" runat="server" Text='<%#: Eval("hienThi") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="ckbHienThi_CheckedChanged" OnLoad="ckbHienThi_Load"/>  
                       </td>
                       <td class="p-2 text-secondary">
                           <asp:CheckBox ID="ckbActive" runat="server" Text='<%#: Eval("Active") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="ckbActive_CheckedChanged" OnLoad="ckbActive_Load"/>  
                       </td>
                       <td class="p-2" style="width:120px;"><asp:LinkButton ID="btnSua" runat="server" CommandName="update" CommandArgument='<%#: Eval("maNewsDeltail")%>' CssClass="text-danger"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil-square" viewBox="0 0 16 16">
  <path d="M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"/>
  <path fill-rule="evenodd" d="M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"/>
</svg> Sửa</asp:LinkButton> | <asp:LinkButton ID="btnXoa" runat="server" CommandName="delete" CommandArgument='<%#: Eval("maNewsDeltail")%>' OnClientClick="javascript:ShowProgressBar()" OnLoad="btnXoa_Load" CssClass="text-danger"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
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
            <asp:HiddenField ID="hdImage11" runat="server" />
            <asp:HiddenField ID="hdValue" runat="server" />
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <asp:Button ID="btnBack" CssClass="btn btn-outline-dark btn-sm" Text="Quay lại" runat="server" OnClick="btnBack_Click"/>
                </div>
                <div class="card-body card-body-scroll">
                    <div class="row">
                        <div class="col-10">
                             <div class="form-group">
                                  <asp:Label ID="lblTenTinTuc" runat="server" Text="Tên tin tức"></asp:Label>
                                  <asp:TextBox ID="txtTenTinTuc" CssClass="form-control" runat="server"></asp:TextBox>
                                 
                             </div>
                        </div>
                       
                        <div class="col-2">
                            <div class="form-group">
                                 <asp:Label ID="lblNews" runat="server" Text="Danh mục tin tức"></asp:Label>
                                 <div class="ui-dropdownlist">
                                <asp:TextBox ID="txtNews" runat="server" CssClass="form-control js-news" placeholder="Chọn danh mục tin tức"></asp:TextBox>
                                </div>
                                  <script>
                                      $(function () {
                                          $('.js-news').autocomplete({
                                              source: function (request, response) {
                                                  $.ajax({
                                                      url: "/admin/News.ashx",
                                                      dataType: "json",
                                                      data: {
                                                          term: request.term
                                                      },
                                                      success: function (data) {

                                                          response($.map(data, function (item) {
                                                              return {
                                                                  tenNews: item.tenNews,
                                                                  
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
                                                  $('.js-news').val(ui.item.tenNews);
                                                  return false;
                                              }
                                          }).focus(function () {
                                              $(this).autocomplete("search", "");
                                          }).data("ui-autocomplete")._renderItem = function (ul, item) {
                                              return $("<li>").append("<div><span class='collection-span'>" + item.tenNews + "</span></div>").appendTo(ul);

                                          };

                                      });
                                  </script>
                                
                            </div>
                        </div>
                        
                    </div>
                    <div class="row">
                        <div class="col-6">
                             <div class="form-group">
                                  <asp:Label ID="lblTitle" runat="server" Text="Tiêu đề"></asp:Label>
                                  <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server"></asp:TextBox>
                                
                            </div>
                        </div>
                        <div class="col-6">
                             <div class="form-group">
                                 <asp:Label ID="lblKeyword" runat="server" Text="Tag"></asp:Label>
                                 <dx:ASPxTokenBox ID="ASPxTokenBox1" runat="server" ItemValueType="System.String" ></dx:ASPxTokenBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                         <div class="col-12">
                             <div class="form-group">
                                 <asp:TextBox ID="txtMetaDescription" CssClass="form-control" runat="server" placeholder="Nhập description" TextMode="MultiLine"></asp:TextBox>
                                 <asp:Label ID="Label4" runat="server"></asp:Label>
                            </div>
                        </div>
                     </div>
                     <div class="row">
                         <div class="col-12">
                             <span>Link sản phẩm QC</span>
                              <div class="ui-dropdownlist">
                                   <asp:TextBox ID="txtLinkSanPhamQC" runat="server" CssClass="form-control"></asp:TextBox>
                              </div>
                         </div>
                     </div>
                    <div class="row">
                        <div class="col">
                            <span class="mb-2">Nội dụng</span>
                            <dx:aspxhtmleditor ID="htmlEditor" runat="server" Width="100%" Height="500px" Theme="Default" >
                               <SettingsDialogs>
                                      <InsertImageDialog ShowMoreOptionsButton="false">
                                        <SettingsImageUpload>
                                            <FileSystemSettings UploadFolder="/images/anh-tin-tuc/" />
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
                            <span>Avatar Home</span>
                            <asp:FileUpload ID="FileUpload2" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 1</span>
                            <asp:FileUpload ID="FileUpload3" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 2</span>
                            <asp:FileUpload ID="FileUpload4" runat="server"/>
                        </div>
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 3</span>
                            <asp:FileUpload ID="FileUpload5" runat="server"/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh 4</span>
                            <asp:FileUpload ID="FileUpload6" runat="server"/>
                        </div>
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
                            <span>Ảnh sản phẩm QC</span>
                            <asp:FileUpload ID="FileUpload10" runat="server"/>
                        </div>
                        
                    </div>
                    <div class="row">
                         <div class="col-3 d-flex flex-column mt-2">
                            <span>Ảnh sản phẩm QC mobile</span>
                            <asp:FileUpload ID="FileUpload12" runat="server"/>
                        </div>
                         <div class="col-2 mt-2">
                            <span>Hiển thị</span>
                            <asp:CheckBox ID="cbkHienThi" runat="server" Text="Active" CssClass="custom-control custom-switch mt-3"/>
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
                             <asp:Literal ID="lblThongBao" runat="server" ></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
    </asp:View>
</asp:MultiView>