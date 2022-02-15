<template>
    <div>
        <el-row>
            <el-col :span="18" :offset="3" class="search">
                <dl>
                    <dt>品牌：</dt>
                    <dd>
                        <a
                            href="javascript:void(0)"
                            v-for="item in brand"
                            :key="item.brandId"
                            @click="search(item,'brand')"
                        >
                            {{ item.brandName }}
                        </a>
                    </dd>
                </dl>

                <dl>
                    <dt>价格区间：</dt>
                    <dd>
                        <a
                            href="javascript:void(0)"
                            v-for="item in range"
                            :key="item.priceRangeId"
                            @click="search(item,'range')"
                        >
                            {{ item.priceRangeName }}
                        </a>
                    </dd>
                </dl>
            </el-col>
        </el-row>
        <el-row>
            <el-col :span="18" :offset="3" class="search order">
                <div>
                    价格
                    <a href="javascript:;" @click="search(undefined,undefined,true)"><i class="el-icon-top"></i></a>
                    <a href="javascript:;" @click="search(undefined,undefined,false)"><i class="el-icon-bottom"></i></a>
                </div>
                <div>
                    <el-checkbox v-model="isstock" @change="search(undefined,'isstock')">只看有库存</el-checkbox>
                </div>
            </el-col>
        </el-row>
        <el-row>
            <el-col :span="18" :offset="3" class="search list">
                <ul>
                    <li v-for="item in goods" :key="item.goodsId">
                        <img
                            :src="item.goodsThum"
                        />
                        <p>
                            {{item.goodsName}}
                             价格：{{item.goodsPrice}}</p>
                        <el-button  type="primary" @click="AddCar(item)">加入购物车</el-button>
                    </li>
                </ul>
            </el-col>
        </el-row>
        <el-row>
            <el-col :span="18" :offset="3" class="page">
                <el-pagination
                    background
                    layout="prev, pager, next"
                    :total="total"
                >
                </el-pagination>
            </el-col>
        </el-row>
    </div>
</template>

<style scoped>
.search {
    background: #fffbfb;
    border: 1px solid #ccc;
    padding-left: 20px;
}
dl {
    clear: both;
    margin-top: 2em;
    height: 16px;
}
dt,
dd {
    float: left;
    margin: 0;
    padding: 0;
}
dt {
    width: 80px;
    background: 1px solid #ccc;
    font-weight: bold;
    color: blueviolet;
    text-align: right;
}
.el-link {
    margin-right: 30px;
}
dd a {
    margin-right: 30px;
    text-decoration: none;
    color: blueviolet;
}
.order {
    padding: 12px;
    margin-top: 12px;
}
.order div {
    float: left;
    margin-right: 24px;
}
ul li {
    list-style-type: none;
    margin: 0;
    padding: 0;
    float: left;
    border: 1px solid #ccc;
    margin-right: 30px;
    margin-bottom: 15px;
    padding: 14px;
}
ul li button{width: 200px;}
ul li img {
    width: 200px;
}
.page{
    margin-top: 30px;
    margin-bottom: 30px;
    text-align: center;
}
</style>

<script>
export default {
    data() {
        return {
            brand: [],
            range: [],
            isstock: false,
            brandId:0,
            rangeId:0,
            orderby:false,
            goods:[],
            total:0
        };
    },
    mounted() {
        this.axios.get("/api/Brand/GetList").then((m) => {
            this.brand = m.data;
        });
        this.axios.get("/api/PriceRange/GetList").then((m) => {
            this.range = m.data;
        });
        this.search(undefined,undefined);
    },
    methods: {
        AddCar(item){
            this.axios.post('/api/Car/Index',{
                goodsId:item.goodsId,
                buyCount:1
            }).then(m=>{
                console.log(m);
            });
        },
        search(item,flag,orderby) {
            if(flag == "brand"){
                this.brandId = item.brandId;
            }
            
            if(flag == "range"){
                this.rangeId = item.priceRangeId;
            }

            this.orderby = orderby;

            if(orderby == undefined){
                this.orderby = true;
            }
            
            this.axios.get(`/api/Goods?brandid=${this.brandId}&rangeId=${this.rangeId}&&isstock=${this.isstock}&field=price&orderby=${this.orderby}`).then(m=>{
                this.goods = m.data.list;
                this.total = m.data.count;
            });
        },
    },
};
</script>