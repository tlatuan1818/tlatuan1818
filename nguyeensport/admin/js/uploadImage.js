function loadInputImage(inputimg, wrapper) {

    const WIDTH = 300
    let input = document.getElementById(inputimg)
    input.addEventListener("change", (event) => {
        let image_file = event.target.files[0]
        let reader = new FileReader
        reader.readAsDataURL(image_file)
        reader.onload = (event) => {
            let image_url = event.target.result
            let image = document.createElement("img")
            image.src = image_url
            image.onload = (e) => {

                let canvas = document.createElement("canvas")
                let ratio = WIDTH / e.target.width
                canvas.width = WIDTH
                canvas.height = e.target.height * ratio
                const context = canvas.getContext("2d")
                context.drawImage(image, 0, 0, canvas.width, canvas.height)
                let new_image_url = context.canvas.toDataURL("image/jpeg", 80)
                let new_image = document.createElement("img")
                new_image.src = new_image_url
                let new_close = document.createElement("span")
                new_close.className = "close icon";
                let spinner = document.createElement("div")
                spinner.style = 'position: absolute; text-align: center; height: 100%; width: 100%; top: -60px; right: 0; left: 0; z-index: 9999999; background-color:#c70101; opacity: 1;'
                let spinner_postion = document.createElement("div")
                spinner_postion.className = 'position-relative';
                spinner_postion.style = 'width: 123px; height: 123px;background-color:rgb(193 193 193);'
                let spinner_img = document.createElement("img")
                spinner_img.src = '/images/common/NGUYEEN-White.svg'
                spinner_img.style = 'width: 65px; position: absolute; top: 50%; left: 50%; height: 65px; margin: 0;transform: translate(-50%, -50%);'
                let spinner_span = document.createElement("span")
                spinner_span.className = 'spinner-border'
                spinner_span.style = 'width: 70px; height: 70px; position:absolute;top:26.5px;left:26.5px;border:2px solid #fff;border-right-color: transparent;'
                spinner.appendChild(spinner_postion)
                spinner_postion.appendChild(spinner_img)
                spinner_postion.appendChild(spinner_span)
                document.getElementById(wrapper).appendChild(spinner)
                setTimeout(() => {
                    document.getElementById(wrapper).removeChild(spinner)
                    document.getElementById(wrapper).appendChild(new_image)
                    document.getElementById(wrapper).appendChild(new_close)
                    new_close.addEventListener("click", function () {
                        document.getElementById(wrapper).removeChild(new_image)
                        document.getElementById(wrapper).removeChild(new_close)
                    })
                }, 2000)


            }
        }
    })
}