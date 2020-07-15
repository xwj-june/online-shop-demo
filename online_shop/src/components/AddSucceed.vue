<template>
    <div>
        <h1>Add product successfully</h1>
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
        this.getProductById(pid);
    },
    methods:{
        
    }
}
</script>
<style scoped>

</style>