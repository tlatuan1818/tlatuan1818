<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="doitra.ascx.cs" Inherits="nguyeensport.Display.Unitl.doitra" %>
<div class="container-box">
            <h1 class="container-name">Đổi trả</h1>
            <div class="container-item">
                <div class="container-content">
                    <div class="container-title">Chính sách đổi trả của bạn là gì ?</div>
                    <div class="container-des" id="show">
                        Tất cả hàng hóa do NGUYEENSPORT cung cấp đều có nguồn gốc chính thức và được bảo hành thông thường của nhà sản xuất. Bạn có thể trả lại bất kỳ mặt hàng nào trong vòng 60 ngày kể từ ngày nhận được hoàn tiền lại hoặc đổi cùng một mặt hàng để lấy kích thước thay thế....
                    </div>
                    <div class="container-des" id="hidden">
                        Tất cả hàng hóa do NGUYEENSPORT cung cấp đều có nguồn gốc chính thức và được bảo hành thông thường của nhà sản xuất. Bạn có thể trả lại bất kỳ mặt hàng nào trong vòng 60 ngày kể từ ngày nhận được hoàn tiền lại hoặc đổi cùng một mặt hàng để lấy kích thước thay thế.<br>
                        Các mặt hàng phải được trả lại trong tình trạng ban đầu, bao gồm mọi bao bì. Ví dụ giày phải được trả với hộp giày ban đầu, bất kỳ thẻ nào được gắn và trong tình trạng mới(Không được sử dụng bên ngoài hoặc trên bề mặt mài mòn).<br>
                        NGUYEENSPORT sẽ chỉ hoàn trả chí phí của bạn cho một sản phẩm nếu nó bị Bộ phận trả hàng tuyên bố là bị lỗi hoặc nếu chúng tôi đã gửi cho bạn một sản phẩm không chính xác. Vui lòng giữ lại biên lại của bạn cho chi phí trả hàng. Khi bạn gửi biên nhận này cho chúng tôi, chúng tôi sẽ sẵn lòng hoàn lại cho bạn những chi phí này.<br>
                        Hàng bị lỗi - Nếu bạn không thể tìm được hãng vận chuyễn, vui lòng gửi cho chung tôi một số hình ảnh về thiệt hại và chung tôi sẽ xem liệu chúng tôi có thể xử lý yêu cầu của bạn mà không cần nhận lại hàng hay không. Xin lưu ý rằng chúng tôi không phải lúc nào cũng có thể xử lý khiếu nại đối với hàng hóa bị lỗi chỉ bằng hình ảnh. <br>
                        Mục cá nhân hóa - Rất tiết, chung tôi không thể chấp nhận đổi trả hàng đã được cá nhân hóa trừ khi đó là lỗi của nhà sản xuất. Nếu bạn tin rằng bạn đã nhận được một sản phẩm bị lỗi hoặc đã xảy ra lỗi khi cá nhân hóa mặc hàng của bạn vui lòng liên hệ với nhóm dich vu khác hàng của chung tôi, họ sẽ sẵn lòng trợ giúp.<br>
                        Tất cả các mặt hàng sẽ được kiểm tra khi trở lại. Chúng tôi có quyền từ chối hoàn tiền hoặc đổi trả nếu hàng hóa được trả lại bị coi là hưng hỏng hoặc giả mạo không phù hợp với nhu cầu sử dụng bình thường. Điều này không ảnh hưởng đến các quyền theo luật định của bạn.
                    </div>
                    <a onclick="showhide()" id="btn-text">Xem thêm</a>
                </div>
            </div>
            <div class="container-item">
                <div class="container-content">
                    <div class="container-title">Tôi có thể đổi món hàng của mình lấy thức khác không?</div>
                    <div class="container-des" id="show1">
                        Chúng tôi hiện chỉ có thể cung cấp dịch vụ trao đổi cho cùng một mặt hàng với kích thước thay thế, mà chúng tôi sẽ gửi cho bạn khi nhận được hàng trả lại. Vui lòng hoàn thành thủ tục giấy tờ, cho biết kích thước bạn muốn nhận.<br>
                        Chúng tôi hiện không thể cung cấp dịch vụ đổi lấy các mặt hàng thay thế. Tuy nhiên, có một cách mà bạn vẫn có thể nhận được món hàng ưng ý và trả lại món hàng không cần nữa....
                    </div>
                    <div class="container-des" id="hidden1">
                        Chúng tôi hiện chỉ có thể cung cấp dịch vụ trao đổi cho cùng một mặt hàng với kích thước thay thế, mà chúng tôi sẽ gửi cho bạn khi nhận được hàng trả lại. Vui lòng hoàn thành thủ tục giấy tờ, cho biết kích thước bạn muốn nhận.<br>
                        Chúng tôi hiện không thể cung cấp dịch vụ đổi lấy các mặt hàng thay thế. Tuy nhiên, có một cách mà bạn vẫn có thể nhận được món hàng ưng ý và trả lại món hàng không cần nữa.Nếu bạn muốn trả lại mặt hàng cho chúng tôi, với điều kiện nó ở trong tình trạng 'như mới', bao gồm không có dấu hiệu hao mòn trên chính mặt hàng đó cộng với nhãn, thẻ và tất cả bao bì, bạn có thể làm như vậy bằng cách gửi lại cho chúng tôi.<br>
                        Miễn là Bộ phận Trả hàng hài lòng với tình trạng của mặt hàng, họ sẽ cung cấp cho bạn một khoản hoàn lại đầy đủ và gửi email cho bạn để cho bạn biết rằng việc này đã được thực hiện. 
                        
                    </div>
                    <a onclick="showhide1()" id="btn-text">Xem thêm</a>
                </div>
            </div>
            <div class="container-item">
                <div class="container-content">
                    <div class="container-title">Bạn đã nhận được hàng trả lại của tôi chưa?</div>
                    <div class="container-des" id="show2">
                        Ngay sau khi chúng tôi nhận được hàng của bạn trả lại, chúng tôi dự kiến ​​sẽ xử lý công việc này cho bạn trong vòng 3-5 ngày làm việc (Thứ Hai-Thứ Sáu). Sau khi bộ phận Trả hàng hoàn tất, bạn sẽ nhận được email xác nhận việc này đã được thực hiện. Nếu bạn chưa nhận được email từ Bộ phận Trả hàng, vui lòng kiểm tra với người chuyển phát để biết sự kiện đã về với chúng tôi...
                    </div>
                    <div class="container-des" id="hidden2">
                        Ngay sau khi chúng tôi nhận được hàng của bạn trả lại, chúng tôi dự kiến ​​sẽ xử lý công việc này cho bạn trong vòng 3-5 ngày làm việc (Thứ Hai-Thứ Sáu).<br>
                        Sau khi bộ phận Trả hàng xử lý xong, bạn sẽ nhận được email xác nhận việc này đã được thực hiện.<br>
                        Nếu bạn chưa nhận được email từ bộ phận Trả hàng, vui lòng kiểm tra với người chuyển phát để biết bưu kiện đã về với chúng tôi. <br>                       
                        Nếu đơn đặt hàng đã về với chúng tôi, vui lòng liên hệ với nhóm Dịch vụ khách hàng của chúng tôi theo địa chỉ nguyeensport@gmail.com với số ID đơn hàng và số theo dõi của bưu kiện bị trả lại để chúng tôi có thể điều tra và giải quyết vấn đề nhanh chóng cho bạn.<br>
                    </div>
                    <a onclick="showhide2()" id="btn-text">Xem thêm</a>
                </div>
            </div> 
        </div>