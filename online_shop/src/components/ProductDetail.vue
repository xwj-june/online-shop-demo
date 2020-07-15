<template>
    <div>
        <div class="product-info">
            <img :src="product.productImageUrl" alt="">
            <p class="product-name">{{product.productName}}</p>
            <p class="product-price">{{product.productPrice}}</p>
            <p>
                <span @click="subNumber()">-</span>
                <!--<input class="product-amount" type="text" :value="count" @change="changeCount()">-->
                <input class="product-amount" type="text" v-model="count" @change="changeCount()"> <!--apply watch-->
                <span @click="plusNumber()">+</span>
            </p>
            <p>
                <button>Add to Cart</button>
            </p>
        </div>
        <div class="product-detail">
            <img :src="product.productDetailImageUrl" alt="">
        </div>
    </div>
</template>
<script>
export default {
    data(){
        return{
            count: 1,
            product:{},
        }
    },
    mounted(){
        var pid = this.$route.query.pid;        
    },
    methods:{

        getProductById(){
            var thisVue = this;
            this.$http
                .get('https://localhost:44356/api/Product/GetProductById/?id='+pid)
                .then(function(res){
                thisVue.product = res.data;
            });
        },
        subNumber(){
            if (this.count>1){
                this.count--;
            }            
        },
        plusNumber(){
            this.count++;
        },
        changeCount(){
            //var newCount = event.target.value;
            //if (!isNaN(newCount) && newCount > 0){ //check if not a number
            //    this.count = newCount;
            //}else{
            //    event.target.value = this.count;
            //}

            //Below: apply v-model and watch
            var newCount = event.target.value; 
        }
    },
    //Below: apply v-model and watch
    watch:{
        count: function(newVal, oldVal){
            if (isNaN(newVal) || newVal <1){
                this.count = oldVal;
            }
        }
    }
}
</script>
<style scoped>
.product-amount{
    width: 30px;
}
</style>