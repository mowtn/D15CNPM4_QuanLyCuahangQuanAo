function Validator(options) {
    function getParent(element, selector) {
        while (element.parentElement) {
            if (element.parentElement.matches(selector)) {
                return element.parentElement
            }
            element = element.parentElement
        }
    }
    function validate(inputElement, rule) {
        var errorElent = getParent(inputElement, options.formGroupSelector).querySelector(options.errorSelector)
        var errorMesseage = rule.test(inputElement.value)
        var formVali = true
        if (errorMesseage) {
            errorElent.innerText = errorMesseage
            getParent(inputElement, options.formGroupSelector).classList.add('invalid')
            formVali = false
        } else {
            errorElent.innerText = ''
            getParent(inputElement, options.formGroupSelector).classList.remove('invalid')
        }
        return formVali
    }
    var formElement = document.querySelector(options.form)
    if (formElement) {

        formElement.onsubmit = function (e) {
            e.preventDefault()
            var formisvalid = true
            options.rules.forEach(function (rule) {
                var inputElement = formElement.querySelector(rule.selector)
                isvalid = validate(inputElement, rule)
                if (!isvalid) {
                    formisvalid = false
                }
            })


            if (formisvalid) {

                if (typeof options.onSubmit === 'function') {
                    console.log(1)
                    var enableInputs = formElement.querySelectorAll('[name]') //trả về giá trị đưuọc lấy từ các thẻ có field = name (formelement chính là đại diện cho thẻ form)
                    var formValues = Array.from(enableInputs).reduce((values, input) => { //vì enableInputs kh phải array thuần nên phải dùng array.from để chuyển về array
                        values[input.name] = input.value
                        return values
                    }, {});
                    options.onSubmit(formValues)

                }
            }
        }


        options.rules.forEach((rule) => {
            var inputElement = formElement.querySelector(rule.selector)

            inputElement.onblur = function () {  // sự kiện bỏ nhấp chuột ra khỏi thẻ inputelens
                validate(inputElement, rule)
            }
            inputElement.oninput = function () {
                getParent(inputElement, options.formGroupSelector).classList.remove('invalid')
                getParent(inputElement, options.formGroupSelector).querySelector(options.errorSelector).innerText = ''
            }
        });
    }
}


//rules
Validator.isRequired = function (selector) {
    return {
        selector: selector,
        test: function (value) {
            return value.trim() ? undefined : 'Vui lòng nhập lại thông tin'
        }
    }
}

Validator.isEmail = function (selector) {
    return {
        selector: selector,
        test: function (value) {
            var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
            return mailformat.test(value) ? undefined : 'Vui lòng nhập lại thông tin đúng định dạng email !'
        }
    }
}


Validator.isLength = function (selector, min) {
    return {
        selector: selector,
        test: function (value) {
            return value.length >= min ? undefined : `Yêu cầu mật khẩu dài hơn ${min} ký tự!`
        }
    }
}
Validator.iscopeted = function (selector, match, messeage) {
    return {
        selector: selector,
        test: function (value) {
            if (value.trim() === '') {
                return value === match() ? undefined : messeage
            }
            return value === match() ? undefined : 'Mật Khẩu không trùng khớp'
        }
    }
}

