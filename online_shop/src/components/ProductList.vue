<template>
  <div class="">
    <div class="product-search">
        <input type="text" id="txtSearch">
        <button>Search</button>
    </div>
    <div class="product-list">
        <ul>            
            <li class="product" v-for="product in productList" :key="product.id">
                <img :src="product.productImageUrl" alt="image">
                <p class="product-price">${{product.price}}</p>
                <p class="product-name">{{product.productName}}</p>
            </li>    
        </ul>
    </div>
  </div>
</template>
<script>
export default {
    data(){
        return{
            productList: [],
        }
    },
    mounted(){
        this.getProductList();
    },
    methods:{
        getProductList:function(){
            var thisVue = this;
            this.$http.get('https://localhost:44356/api/Product/GetProducts').then(function(res){
                thisVue.productList = res.data;
            });
        }
    },
}
</script>

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
