<template>
    <div>
        <el-row>
            <el-col :span="18" :offset="3"  class="search">
                <dl>
                    <dt>品牌：</dt>
                    <dd>
                        <a href="javascript:void(0)" v-for="item in brand" :key="item.brandId" @click="search(item)">
                        {{item.brandName}}
                        </a>
                    </dd>
                </dl>

                <dl>
                    <dt>价格区间：</dt>
                    <dd>
                        <el-link href="https://element.eleme.io" target="_blank"
                            >默认链接</el-link
                        >
                        <el-link type="primary">主要链接</el-link>
                        <el-link type="success">成功链接</el-link>
                        <el-link type="warning">警告链接</el-link>
                        <el-link type="danger">危险链接</el-link>
                        <el-link type="info">信息链接</el-link>
                    </dd>
                </dl>
            </el-col>
        </el-row>
    </div>
</template>

<style scoped>
.search{background: #fffbfb; border: 1px solid #ccc; padding-left: 20px;}
dl{clear: both; margin-top: 2em; height: 16px;}
dt,dd{float: left;margin: 0; padding: 0;}
dt{width: 80px; background: 1px solid #ccc; font-weight: bold; color: blueviolet; text-align: right;}
.el-link{margin-right: 30px;}
</style>

<script>
export default {
    data() {
        return {
            brand:[]
        }
    },
    mounted() {
        this.axios.get('/api/Brand/GetList').then(m=>{
            this.brand = m.data;
        });
    },
    methods: {
        search(item){
            console.log('123');
            console.log(item);
        }
    },
}
</script>