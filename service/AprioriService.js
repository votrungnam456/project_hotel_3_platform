'use strict'
const queryBuilder = require('../config/database');
class AprioriService {
    static async listDataService(req) {
        try {
            let MaKP = req.params.MaKP;
            let getData = await queryBuilder().select('phieu_thanh_toan.MaPDK', 'kieuphong.TenKP', 'dichvu.TenDV').from('phieu_thanh_toan')
                .join('phieu_dang_ky', { 'phieu_dang_ky.MaPDK': 'phieu_thanh_toan.MaPDK' }).
                join('phong', { 'phong.Maphong': 'phieu_dang_ky.Maphong' }).
                join('kieuphong', { 'phong.MaKP': 'kieuphong.MaKP' }).
                join('hoadondichvu', { 'hoadondichvu.MaPDK': 'phieu_dang_ky.MaPDK' }).
                join('dichvu', { 'dichvu.ID_DV': 'hoadondichvu.ID_DV' }).where("phong.MaKP",MaKP);
            let arr = [];
            for (let i = 0; i < getData.length; i++) {
                arr.push(getData[i]["MaPDK"])
            }
            let arrZ = [...new Set(arr)]
            console.log(arrZ)
            let arrResult = [];
            for (let i = 0; i < arrZ.length; i++) {
                let newObj = {
                    MaPDK: arrZ[i],
                    TenKP: "",
                    TenDV: ""
                };
                for (let j = 0; j < getData.length; j++) {
                    if (getData[j]["MaPDK"] == arrZ[i]) {
                        if (!newObj.TenDV.includes(getData[j]["TenDV"])) {
                            newObj.TenDV += getData[j]["TenDV"] + " ; "
                            newObj.TenKP = getData[j]["TenKP"]
                        }
                    }
                }
                arrResult.push(newObj);
            }
            return getData;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async listFieldNameService(req) {
        try {
            let service = await queryBuilder('dichvu').select('dichvu.TenDV');
            let typeRooms = await queryBuilder('kieuphong').select('kieuphong.TenKP');
            let result = []
            typeRooms.forEach(element => {
                result.push(element["TenKP"])
            });
            service.forEach(element => {
                result.push(element["TenDV"])
            });
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = AprioriService