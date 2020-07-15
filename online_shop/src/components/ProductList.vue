<template>
  <div class="">
    <div class="product-search">
        <input type="text" id="txtSearch">
        <button>Search</button>
    </div>
    <div class="product-list">
        <ul>
            <li class="product">
                <img src="https://d3fa68hw0m2vcc.cloudfront.net/3e1/233270737.jpeg" alt="image">
                <p class="product-price">$1020.0</p>
                <p class="product-name">laptop</p>
            </li>
            <li class="product">
                <img src="https://d3fa68hw0m2vcc.cloudfront.net/3e1/233270737.jpeg" alt="image">
                <p class="product-price">$1020.0</p>
                <p class="product-name">laptop</p>
            </li>
            <li class="product">
                <img src="https://d3fa68hw0m2vcc.cloudfront.net/3e1/233270737.jpeg" alt="image">
                <p class="product-price">$1020.0</p>
                <p class="product-name">laptop</p>
            </li>
        </ul>
    </div>
  </div>
</template>
<style scoped>
.product-search{
    margin-bottom: 100px;
}
.product-list{
    width: 1200px;
    margin: auto;
}
.product-list ul{
    list-style: none;
}
    .product{
        display: inline-block;
        width: 25%;
        margin: 20px 15px;
        cursor: pointer;
    }
    .product:hover{
        box-shadow: 0 0 10px #eeeeee;
    }
    .product img{
        width: 100%;
    }
    .product-price{
        font-weight: 800;
    }
    .product-name{
        font-size: 20px;
    }
</style>>
