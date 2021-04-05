'use strict'
const RoomsService = require("../service/RoomsService");
class RoomsController{
     static async list(req, res, next){
          try {
              let data = await RoomsService.listRoomService(req);
              res.status(200).json({
                  status: "SUCCESS",
                  errors:null,
                  data: {
                      result: data
                  }
              });
          } catch (e) {
              res.status(200).json({
                  status: "FAIL",
                  errors: [{
                      code: 1000,
                      message: "Server Error"
                  }],
                  data: null
              });
          }
      }
}
module.exports = RoomsController