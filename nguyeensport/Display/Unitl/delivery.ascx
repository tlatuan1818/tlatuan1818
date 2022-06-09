<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="delivery.ascx.cs" Inherits="nguyeensport.Display.Unitl.delivery" %>
<div class="container-box">
            <h1 class="container-name">Vận chuyển</h1>
            <div class="container-item">
                <div class="container-content">
                    <div class="container-title">Làm cách nào để theo dõi đơn hàng của tôi ?</div>
                    <div class="container-des" id="show">
                        Khi đơn hàng của bạn được gửi đi, chúng tôi sẽ gửi cho bạn một email hoặc gọi cho bạn để xác nhận đơn đặt hàng đang đang được gửi đến bạn.<br>
                        Tất cả các giao hàng sẽ phải được ký kết trong khoản thời gian từ 9 giờ sáng đến 18 giờ chiều. Nếu bạn bỏ lỡ giao hàng, chúng tôi sẽ cố gắng giao hàng vào ngày làm việc tiếp theo.<br>
                        ...
                    </div>
                    <div class="container-des" id="hidden">
                        Khi đơn hàng của bạn được gửi đi, chúng tôi sẽ gửi cho bạn một email hoặc gọi cho bạn để xác nhận đơn đặt hàng đang đang được gửi đến bạn.<br>
                        Tất cả các giao hàng sẽ phải được ký kết trong khoản thời gian từ 9 giờ sáng đến 18 giờ chiều. Nếu bạn bỏ lỡ giao hàng, chúng tôi sẽ cố gắng giao hàng vào ngày làm việc tiếp theo.<br>
                        Nếu bưu kiện của bạn chưa đến trong thời gian giao hàng dự kiến thì vui lòng liên hệ với nhóm Dịch vụ Khách hàng của chúng tôi tại nguyeensport@gmail.com.
                    </div>
                    <a onclick="showhide()" id="btn-text">Xem thêm</a>
                </div>
            </div>
            <div class="container-item">
                <div class="container-content">
                    <div class="container-title">Có những lựa chọn giao hàng nào ?</div>
                    <div class="container-des" id="show1">
                        Chúng tôi cung cấp ba tùy chọn giao hàng: Tiêu chuẩn / Ngày hôm sau / Chuyển phát nhanh. Bạn có thể nhận thấy trong quá trình thanhh toán mà không phải tất cả các tùy chọn đề có sãn cho bạn - các phụ thuộc tùy chọn vào vị trí của bạn trên thế giới, bạn đang nhận đơn hàng và tổng trọng lượng của đơn treo. Bạn sẽ được cung cấp hàng hóa tùy chọn khi thanh toán cùng với ngày giao hàng dự kiến....
                        
                    </div>
                    <div class="container-des" id="hidden1">
                        Chúng tôi cung cấp ba tùy chọn giao hàng: Tiêu chuẩn / Ngày hôm sau / Chuyển phát nhanh.<br>
                        Bạn có thể nhận thấy trong quá trình thanhh toán mà không phải tất cả các tùy chọn đề có sãn cho bạn - các phụ thuộc tùy chọn vào vị trí của bạn trên thế giới, bạn đang nhận đơn hàng và tổng trọng lượng của đơn treo.<br>
                        Bạn sẽ được cung cấp hàng hóa tùy chọn khi thanh toán cùng với ngày giao hàng dự kiến.<br>
                        Nếu bạn đang đặt nhiều mặt hàng và Giao hàng bình thương không phải là một tùy chọn do trọng lượng của đơn hàng, bạn có thể đặt nhiều đơn hàng nhở hơn, vì vậy tùy chọn Tiêu chuẩn sẽ khả dụng.
                        
                    </div>
                    <a onclick="showhide1()" id="btn-text">Xem thêm</a>
                </div>
            </div>
            <div class="container-item">
                <div class="container-content">
                    <div class="container-title">Đơn hàng của tôi chưa đến - Tôi phải làm gì ?</div>
                    <div class="container-des" id="show2">
                        Chúng tôi rất tiếc nếu đơn hàng của bạn bị mất nhiều thời gian hơn dự kiến để đến nơi. Các tính năng giao hàng hằng ngày sẽ được hiển thị trong quá trình thanh toán khi bạn đặt hàng vui lòng đợi đến ngày để đơn hàng của bạn đến nơi...
                    </div>
                    <div class="container-des" id="hidden2">
                        Chúng tôi rất tiếc nếu đơn hàng của bạn bị mất nhiều thời gian hơn dự kiến để đến nơi.<br>
                        Các tính năng giao hàng hằng ngày sẽ được hiển thị trong quá trình thanh toán khi bạn đặt hàng vui lòng đợi đến ngày để đơn hàng của bạn đến nơi.<br>
                        Có thể dễ dàng theo dõi tất cả các sự kiện được gửi với người chuyển phát của chúng tôi trên trang web của đơn vị chuyển phát.<br>
                        Bạn có thể truy cập liên kết này trong 'Đơn hàng của tôi' khi bạn đã đăng nhập vào tài khoản trực tuyến của mình.<br>
                        Nếu có sự chậm trễ, cần có một chỉ dẫn rõ ràng về vị trí của bưu kiện và có khả năng là nguyên nhân của sự chậm trễ.
                    </div>
                    <a onclick="showhide2()" id="btn-text">Xem thêm</a>
                </div>
            </div> 
        </div>