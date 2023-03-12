// ẩn hiện box đăng nhập
    function hidede(){
    var hidee = document.getElementById('HD_topright-sign');        
    if(hidee.style.display === "block")
        {
            hidee.style.display = "none";
        }else{
            hidee.style.display = "block";
        }
}

function pagehide(){
    var hidei = document.getElementById('aruge-section');
    if(hidei.style.display ==='none')
    {
        hidei.style.display ='block';
    }else{
        hidei.style.display ='none';
    }
}

var counter = 1;
setInterval(function(){
    document.getElementById('radio'+counter).checked = true;
    counter++;
    if(counter > 3)
        counter = 1;
}, 3500);

function showMoreTlustt() {
    alert("helee")
    var showMoreTlust = document.querySelector('.more-cus')
    console.log(showMoreTlust)
    if (showMoreTlust.style.height === 37) {
        showMoreTlust.style.height = 120
    } else {
        showMoreTlust.style.height = 37
    }
}

function upquan() {
    var up = document.getElementById('ipQuantity');
    console.log("hêlo");
    up.innerHTML++;
}

function search() {
    var searchItem = document.getElementById('searchstr');
    var sa = document.getElementById('iconsr');
    if (searchItem.style.display === "none") {
        sa.style.color = "red"
        searchItem.style.display = "block"
    } else {
        searchItem.style.display = "none"
        sa.style.color = "black"
    }
   
}
function showTb(id) {
    var tolal = 0;
    var showtable = document.getElementById('showTable');
    var table = document.getElementById('table-' + id);
    var listsp = document.querySelectorAll('itemOrder');
    listsp.forEach((item,index) => {
        

    });
    if (table.style.display === "none") {
        
        table.style.display = "block"
    } else {
        table.style.display = "none"
    }
    
    
}
function selectsize(id) {
    const box = document.querySelector('.box-' + id);
    box.setAttribute('id', 'box');
}
