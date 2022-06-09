<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="category.ascx.cs" Inherits="nguyeensport.admin.ortherpage.category" %>

<h1 class="h3 mb-2 text-gray-800">Quản lý danh mục</h1>
<asp:MultiView ID="mlv" runat="server" ActiveViewIndex="0">
    <asp:View ID="v1" runat="server">
        <!-- DataTales Example -->
        <div class="card shadow mb-4">
            <div class="card-header py-3">
                <asp:Button ID="btnAdd" CssClass="btn btn-outline-danger btn-sm" Text="Thêm danh mục" runat="server" OnClick="btnAdd_Click" />
            </div>
            <div class="card-body">
                 <div class="dvProgressBar" style=" visibility:hidden;position: fixed; text-align: center; height: 100%; width: 100%; top: 0; right: 0; left: 0; z-index: 9999999; background-color: #000000; opacity: 0.84;">
                      <div class="position-relative"  style="width: 100%;height: 100%;">
                         <img src="/images/common/NGUYEEN-White.svg" style="width: 100px; position:absolute;top:50%;left:50%; height: 100px;margin:0;"/>      
                         <div class="spinner-border" style="width: 100px; height: 100px; position:absolute;top:50%;left:50%;" role="status"></div>
                      </div>
                  </div>
                  <ul class="p-0">
                    <asp:Repeater ID="rptListProduct" runat="server" OnItemDataBound="rptListProduct_ItemDataBound" OnItemCommand="rptListProduct_ItemCommand">
                        <HeaderTemplate>
                            <li class="d-flex bg-dark"><div class="header-list w-25">Tên danh mục</div><div class="header-list w-75">Link danh mục</div><div class="header-list w-50">Title danh mục</div><div class="header-list w-50">Tag</div><div class="header-list w-15">Hiển thị</div><div class="header-list w-15">Active</div><div class="header-list w-15"></div></li>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:HiddenField ID="hdMaDanhMuc" Value='<%#:Eval("maDanhMuc") %>' runat="server" />
                            <li class="d-flex">
                                 <div class="header-list-item w-25  js-tree"><%#: Eval("tenDanhMuc") %></div>
                                 <div class="header-list-item w-75"><a href='<%#: Eval("linkDanhMuc") %>' target="_blank"><%#: Eval("linkDanhMuc") %></a></div>
                                 <div class="header-list-item w-50"><%#: Eval("titleDanhMuc") %></div>
                                 <div class="header-list-item w-50"><%#: Eval("metaKeywordsDanhMuc") %></div>
                                 <div class="header-list-item w-15"><asp:CheckBox ID="ckbHienThi" runat="server" Text='<%#: Eval("hienThi") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="ckbHienThi_CheckedChanged" OnLoad="ckbHienThi_Load" /></div>
                                 <div class="header-list-item w-15"><asp:CheckBox ID="cbkActive" runat="server" Text='<%#: Eval("Active") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="cbkActive_CheckedChanged"  OnLoad="cbkActive_Load"/></div>
                                 <div class="header-list-item w-15">
                                     <asp:LinkButton ID="lnkbutAdd" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMuc") %>' CommandName="insert">
                                         <i class="fas fa-fw fa-plus"></i>
                                     </asp:LinkButton>
                                     <asp:LinkButton ID="lnkbutEdit" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMuc") %>' CommandName="update">
                                         <i class="fas fa-fw fa-pen-square"></i>
                                     </asp:LinkButton>
                                     <asp:LinkButton ID="lnkbutDelete" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMuc") %>' CommandName="delete"  OnClientClick="javascript:ShowProgressBar()" OnLoad="btnXoa_Load">
                                         <i class="fas fa-fw fa-trash"></i>
                                     </asp:LinkButton>
                                 </div>
                            </li>
                            <div class="tree-list-section--global">
                                 <asp:Repeater ID="rptSubMenuList" runat="server" OnItemCommand="rptSubMenuList_ItemCommand">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hfViTri" Value='<%#: Eval("viTri") %>' runat="server" />
                                        <asp:HiddenField ID="hfIDDanhMucCon" Value='<%#: Eval("maDanhMucCon") %>' runat="server" />
                                        <div class="tree-list-column">
                                             <ul class="p-0">
                                                <li class="d-flex">
                                                    <div class="tree-list-panert-item w-25"><%#: Eval("tenDanhMucCon") %></div>
                                                    <div class="tree-list-panert-item w-75"><a href='<%#: Eval("linkDanhMucCon") %>' target="_blank"><%#: Eval("linkDanhMucCon") %></a></div>
                                                    <div class="tree-list-panert-item w-50"><%#: Eval("titleDanhMucCon") %></div>
                                                    <div class="tree-list-panert-item w-50"><%#: Eval("metaKeywordsDanhMucCon") %></div>
                                                    <div class="tree-list-panert-item w-15"><asp:CheckBox ID="ckbHienThi1" runat="server" Text='<%#: Eval("hienThi") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="ckbHienThi1_CheckedChanged" OnLoad="ckbHienThi1_Load"/></div>
                                                    <div class="tree-list-panert-item w-15"><asp:CheckBox ID="ckbActive1" runat="server" Text=' <%#: Eval("Active") %>' CssClass="custom-control custom-switch"  AutoPostBack="true" OnCheckedChanged="ckbActive1_CheckedChanged" OnLoad="ckbActive1_Load"/></div>
                                                    <div class="tree-list-panert-item w-15">
                                                        <asp:LinkButton ID="lnkbutAdd1" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMucCon") %>' CommandName="insert">
                                                            <i class="fas fa-fw fa-plus"></i>
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="lnkbutEdit1" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMucCon") %>' CommandName="update">
                                                            <i class="fas fa-fw fa-pen-square"></i>
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="lnkbutDelete1" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMucCon") %>' CommandName="delete"  OnClientClick="javascript:ShowProgressBar()"  OnLoad="btnXoa_Load">
                                                            <i class="fas fa-fw fa-trash"></i>
                                                        </asp:LinkButton>
                                                    </div>
                                                </li>
                                                 <div class="tree-list__content">
                                                     <asp:Repeater ID="rptMenuList2" runat="server" OnItemCommand="rptMenuList2_ItemCommand">
                                                         <ItemTemplate>
                                                              <asp:HiddenField ID="hfMaDanhMucConCap1" runat="server" Value='<%#: Eval("maDanhMucConCap1") %>' />
                                                              <ul class="p-0">
                                                                <li class="d-flex">
                                                                    <div class="tree-list-child-item w-25"><%#: Eval("tenDanhMucConCap1") %></div>
                                                                    <div class="tree-list-child-item w-75"><a href='<%#: Eval("linkDanhMucConCap1") %>' target="_blank"><%#: Eval("linkDanhMucConCap1") %></a></div>
                                                                    <div class="tree-list-child-item w-50"><%#: Eval("titleDanhMucConCap1") %></div>
                                                                    <div class="tree-list-child-item w-50"><%#: Eval("metaKeywordsDanhMucConCap1") %></div>
                                                                    <div class="tree-list-child-item w-15"><asp:CheckBox ID="ckbHienThi2" runat="server" Text='<%#: Eval("hienThi") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="ckbHienThi2_CheckedChanged" OnLoad="ckbHienThi2_Load" /></div>
                                                                    <div class="tree-list-child-item w-15"><asp:CheckBox ID="ckbActive2" runat="server" Text=' <%#: Eval("Active") %>' CssClass="custom-control custom-switch" AutoPostBack="true" OnCheckedChanged="ckbActive2_CheckedChanged" OnLoad="ckbActive2_Load" /></div>
                                                                    <div class="tree-list-child-item w-15">
                                                                        <asp:LinkButton ID="lnkbutEdit2" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMucConCap1") %>' CommandName="update">
                                                                            <i class="fas fa-fw fa-pen-square"></i>
                                                                        </asp:LinkButton>
                                                                        <asp:LinkButton ID="lnkbutDelete2" runat="server" CssClass="text-danger" CommandArgument='<%#:Eval("maDanhMucConCap1") %>' CommandName="delete"  OnClientClick="javascript:ShowProgressBar()"  OnLoad="btnXoa_Load">
                                                                            <i class="fas fa-fw fa-trash"></i>
                                                                        </asp:LinkButton>
                                                                    </div>
                                                                </li>
                                                              </ul>
                                                         </ItemTemplate>
                                                     </asp:Repeater>
                                                 </div>
                                            </ul>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>
    </asp:View>
    <asp:View ID="v2" runat="server">
            <asp:HiddenField ID="hdInsert" runat="server" />
            <asp:HiddenField ID="hdValue" runat="server" />
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <asp:Button ID="btnBack" CssClass="btn btn-outline-dark btn-sm" Text="Quay lại" runat="server" OnClick="btnBack_Click"/>
                </div>
                <div class="card-body card-body-scroll">
                    <div class="row">
                        <div class="col">
                             <div class="form-group">
                                 <asp:TextBox ID="txtTenDanhMuc" CssClass="form-control" runat="server" placeholder="Tên danh mục"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                             <div class="form-group">
                                  <asp:Label ID="lblTieuDe" runat="server" Text="Tiêu đề"></asp:Label>
                                 <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server" placeholder="Nhập tiêu đề"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-6">
                             <div class="form-group">
                                  <asp:Label ID="lblKyword" runat="server" Text="Tag"></asp:Label>
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
                        <div class="col-2 mt-2">
                            <span>Hiển thị</span>
                            <asp:CheckBox ID="cbkHienThi" runat="server" Text="Hiển thị" CssClass="custom-control custom-switch mt-2"/>
                        </div>
                        <div class="col-2 mt-2">
                            <span>Active</span>
                            <asp:CheckBox ID="cbkActive" runat="server" Text="Active" CssClass="custom-control custom-switch mt-2"/>
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
                             <asp:Literal ID="lblThongBao1" runat="server" ></asp:Literal>
                        </div>
                    
                    </div>
                </div>
            </div>
    </asp:View>
    <asp:View ID="v3" runat="server">
          <asp:HiddenField ID="hdInsert1" runat="server" />
          <asp:HiddenField ID="hdImage1" runat="server" />
          <asp:HiddenField ID="hdImage2" runat="server" />
          <asp:HiddenField ID="hdValue1" runat="server" />
          <asp:HiddenField ID="hdValue2" runat="server" />
          <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <asp:Button ID="btnBack1" CssClass="btn btn-outline-dark btn-sm" Text="Quay lại" runat="server" OnClick="btnBack_Click"/>
                </div>
                <div class="card-body card-body-scroll">
                    <div class="row">
                        <div class="col">
                             <div class="form-group">
                                 <asp:TextBox ID="txtTenDanhMucCon" CssClass="form-control" runat="server" placeholder="Tên danh mục con"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-2">
                             <div class="form-group">
                                 <asp:TextBox ID="txtVitri" CssClass="form-control" runat="server" placeholder="Vị trí"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                             <div class="form-group">
                                  <asp:Label ID="Label1" runat="server" Text="Tiêu đề"></asp:Label>
                                 <asp:TextBox ID="txtTitlePanertCategori" CssClass="form-control" runat="server" placeholder="Nhập tiêu đề"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-6">
                             <div class="form-group">
                                  <asp:Label ID="Label2" runat="server" Text="Tag"></asp:Label>
                                 <dx:ASPxTokenBox ID="ASPxTokenBox2" runat="server" ItemValueType="System.String" ></dx:ASPxTokenBox>
                                
                            </div>
                        </div>
                    </div>
                    <div class="row">
                         <div class="col-12">
                             <div class="form-group">
                                 <asp:TextBox ID="txtMetaDescriptionPanertCategori" CssClass="form-control" runat="server" placeholder="Nhập description" TextMode="MultiLine"></asp:TextBox>
                                 <asp:Label ID="Label3" runat="server"></asp:Label>
                            </div>
                        </div>
                     </div>
                     <div class="row">
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh bìa desktop</span>
                            <asp:FileUpload ID="FileUpload1" runat="server"/>
                        </div>
                          <div class="col d-flex flex-column mt-2">
                            <span>Ảnh bìa mobile</span>
                            <asp:FileUpload ID="FileUpload2" runat="server"/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-2 mt-2">
                            <span>Hiển thị</span>
                            <asp:CheckBox ID="ckbHienThi1" runat="server" Text="Hiển thị" CssClass="custom-control custom-switch mt-2"/>
                        </div>
                        <div class="col-2 mt-2">
                            <span>Active</span>
                            <asp:CheckBox ID="ckbActive1" runat="server" Text="Active" CssClass="custom-control custom-switch mt-2"/>
                        </div>
                        <div class="col mt-2 d-flex justify-content-end">
                            <asp:LinkButton ID="btnUpdatePanertCategori" runat="server" CssClass="btn btn-danger mt-4 position-relative"  OnClick="btnUpdatePanertCategori_Click" OnClientClick="javascript:ShowProgressBar()">Update
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
    <asp:View ID="v4" runat="server">
        <asp:HiddenField ID="hdInsert3" runat="server" />
        <asp:HiddenField ID="hdValue3" runat="server" />
        <asp:HiddenField ID="hdValue4" runat="server" />
        <asp:HiddenField ID="hdImage3" runat="server" />
        <asp:HiddenField ID="hdImage4" runat="server" />
         <div class="card shadow mb-4">
              <div class="card-header py-3">
                    <asp:Button ID="btnBlack2" CssClass="btn btn-outline-dark btn-sm" Text="Quay lại" runat="server" OnClick="btnBack_Click"/>
              </div>
              <div class="card-body card-body-scroll">
                    <div class="row">
                        <div class="col">
                             <div class="form-group">
                                 <asp:TextBox ID="txtTenChildCatagories" CssClass="form-control" runat="server" placeholder="Tên danh mục con cấp 1"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-2">
                             <div class="form-group">
                                 <asp:TextBox ID="txtViTriChild" CssClass="form-control" runat="server" placeholder="Vị trí"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                             <div class="form-group">
                                  <asp:Label ID="lblTitleChild" runat="server" Text="Tiêu đề"></asp:Label>
                                 <asp:TextBox ID="txtTitleChild" CssClass="form-control" runat="server" placeholder="Nhập tiêu đề"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-6">
                             <div class="form-group">
                                  <asp:Label ID="lblKeyWordChild" runat="server" Text="Tag"></asp:Label>
                                 <dx:ASPxTokenBox ID="txtKeywordChild" runat="server" ItemValueType="System.String" ></dx:ASPxTokenBox>
                                
                            </div>
                        </div>
                    </div>
                    <div class="row">
                         <div class="col-12">
                             <div class="form-group">
                                 <asp:Label ID="lblMetaDescriptionChild" runat="server"></asp:Label>
                                 <asp:TextBox ID="txtMetaDescriptionChild" CssClass="form-control" runat="server" placeholder="Nhập description" TextMode="MultiLine"></asp:TextBox>
                                
                            </div>
                        </div>
                     </div>
                   <div class="row">
                        <div class="col d-flex flex-column mt-2">
                            <span>Ảnh bìa desktop</span>
                            <asp:FileUpload ID="FileUpload3" runat="server"/>
                        </div>
                          <div class="col d-flex flex-column mt-2">
                            <span>Ảnh bìa mobile</span>
                            <asp:FileUpload ID="FileUpload4" runat="server"/>
                        </div>
                    </div>
                   <div class="row">
                        <div class="col-2 mt-2">
                            <span>Hiển thị</span>
                            <asp:CheckBox ID="cbkHienThi2" runat="server" Text="Hiển thị" CssClass="custom-control custom-switch mt-2"/>
                        </div>
                        <div class="col-2 mt-2">
                            <span>Active</span>
                            <asp:CheckBox ID="cbkActive2" runat="server" Text="Active" CssClass="custom-control custom-switch mt-2"/>
                        </div>
                        <div class="col mt-2 d-flex justify-content-end">
                            <asp:LinkButton ID="btnUpdateChildCategories" runat="server" CssClass="btn btn-danger mt-4 position-relative" OnClientClick="javascript:ShowProgressBar()" OnClick="btnUpdateChildCategories_Click">Update
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
                             <asp:Literal ID="lblThongBao2" runat="server"></asp:Literal>
                        </div>
                    
                    </div>
              </div>
         </div>
    </asp:View>
</asp:MultiView>
