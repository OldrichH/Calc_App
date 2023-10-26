{
    class Calc {

        constructor(previousValueElement, currentValueElement, selectedOperationElement) {
            this.previousValueElement = previousValueElement;
            this.currentValueElement = currentValueElement;
            this.selectedOperationElement = selectedOperationElement;
            this.clear();
            this.showResult();
        }
        clear() {
            this.previousValue = '';
            this.currentValue = '';
            this.operation = null;
        }

        appendNumber(number) {
            if (number === ',' && (this.currentValue.includes(',') || this.currentValue === '')) return;
            this.currentValue = this.currentValue.toString() + number.toString();
        }
        appendOperation(operation) {
            if (this.currentValue === '') return;
            if (this.previousValue != '') return;
            this.operation = operation;
            this.previousValue = this.currentValue;
            this.currentValue = '';
        }

        update() {
            this.currentValueElement.value = this.currentValue;
            if (this.operation != null) {
                this.selectedOperationElement.value = this.operation;
                this.previousValueElement.value = this.previousValue;
            }
            else {
                this.selectedOperationElement.value = '';
                this.previousValueElement.value = '';
            }
        }
        showResult() {
            if(this.currentValueElement.value != '') {
                this.currentValue = this.currentValueElement.value;
                this.update();
            }
        }
    }

    const numbers = document.querySelectorAll('[data-number]');
    const operations = document.querySelectorAll('[data-operation]');
    const currentValueElement = document.querySelector('[data-current]');
    const previousValueElement = document.querySelector('[data-previous]');
    const selectedOperationElement = document.querySelector('[data-operation-selected]');
    const deleteButton = document.querySelector('[data-manage]');

    const input = document.querySelectorAll('[data-expand]');
    const checkBox = document.getElementById("checkBox");

    input.forEach(input => { resize(input) });
    const calc = new Calc(previousValueElement, currentValueElement, selectedOperationElement);


    numbers.forEach(button => {
        button.addEventListener('click', () => {
            calc.appendNumber(button.innerText);
            calc.update();
            TriggerChangeOnInput();

        })
    })
    operations.forEach(op => {
        op.addEventListener('click', () => {
            calc.appendOperation(op.innerText)
            calc.update()
            TriggerChangeOnInput();
        })
    })

    deleteButton.addEventListener('click', () => {
        calc.clear();
        calc.update();
        TriggerChangeOnInput();
    })

    input.forEach(input => {
        input.addEventListener('change', () => {
            resize(input);
        })
    })

    function resize(input) {
        input.style.width = input.value.length + "ch";
    }
    function TriggerChangeOnInput() {
        input.forEach(x => x.dispatchEvent(new Event('change')));
    }

    checkBox.addEventListener('click', () => {
        if (checkBox.value === "True") {
            checkBox.value = "False";
        } else {
            checkBox.value = "True";
        }        
    });

    function GetResult() {
        var calcData = {};
        calcData.ValueA = $("#ValueA").val();
        calcData.ValueB = $("#ValueB").val();
        calcData.Operation = $("#Operation").val();
        calcData.ReturnInteger = $("#checkBox").val();

        console.log(calcData.ValueA + " " + calcData.Operation + " " + calcData.ValueB);
        $.ajax({
            type: 'POST',
            url: '/Home/Calculate',
            data: calcData,
            success: function (r) {
                calc.clear();
                calc.currentValue = r.toString();
                calc.update();
                TriggerChangeOnInput();
                GetHistoryView();               
            },
            error: function () {
                console.log("chybka");
            }
        });
    }
    function GetHistoryView() {
        $.ajax({
            type: 'GET',
            url: '/Home/GetPartial',
            success: function (result){
                $('#PartialView').html(result);
            },
            error: function() {
                console.log("chybka");
            }
        });
    }
}