<template>
  <div>
    <el-row>
      <el-col :span="18" :offset="3" class="search">
        <el-table :data="tableData" style="width: 100%">
          <el-table-column label="商品名称" class="goodsNmae">
            <template slot-scope="scope">
              <div>
                <img :src="scope.row.goodsThum" width="40" />
              </div>
              <div>
                {{ scope.row.goodsName }}
              </div>
            </template>
          </el-table-column>
          <el-table-column label="价格">
            <template slot-scope="scope">
              {{ scope.row.goodsPrice }}
            </template>
          </el-table-column>
          <el-table-column label="购买数量">
            <template slot-scope="scope">
              <el-input-number
                size="mini"
                :min="1"
                v-model="scope.row.buyCount"
                @change="handleChange(scope.row)"
              ></el-input-number>
            </template>
          </el-table-column>
          <el-table-column label="小计">
            <template slot-scope="scope">
              {{ scope.row.buyCount * scope.row.goodsPrice }}
            </template>
          </el-table-column>
          <el-table-column label="删除">
            <template slot-scope="scope">
              <el-button type="warning" size="mini" @click="delCar(scope.row)"
                >删除</el-button
              >
            </template>
          </el-table-column>
        </el-table>
        <div class="footInfo">
          总数量：
          {{ this.tableData.length }}
          总价格：
          {{ totalPrice }}
          <el-button type="danger" style="float:right;margin-top:10px; margin-right:10px">结算订单</el-button>
        </div>
      </el-col>
    </el-row>
  </div>
</template>

<script>
export default {
  data() {
    return {
      property: 'value',
    };
  },
  me
}
</script>

<style scoped>
.goodsNmae div,
.cell div {
  float: left;
}
.search {
  background: #fffbfb;
  border: 1px solid #ccc;
  padding-left: 20px;
}
.footInfo {
  height: 50px;
  line-height: 50px;
  font-size: 16px;
  font-weight: bold;
}
</style>

<script>
export default {
  data() {
    return {
      tableData: [],
      totalPrice: 0,
    };
  },
  methods: {
    handleChange(scope) {
      var price = 0;
      this.tableData.forEach((v) => {
        price += v.goodsPrice * scope.buyCount;
      });
      this.totalPrice = price;

      this.axios
        .post("/api/Car/UpdateCar", {
          goodsId: scope.goodsId,
          buyCount: scope.buyCount,
        })
        .then((m) => {
          console.log(m);
        });
    },
    delCar(scope) {
      this.axios.get("/api/Car/DelCar?id=" + scope.goodsId).then((m) => {
          this.load();
      });
    },
    load() {
      this.axios.get("/api/Car/GetCar").then((m) => {
        this.tableData = m.data;
        var price = 0;
        this.tableData.forEach((v) => {
          price += v.goodsPrice * v.buyCount;
        });
        this.totalPrice = price;
      });
    },
  },
  mounted() {
    this.load();
  },
};
</script>