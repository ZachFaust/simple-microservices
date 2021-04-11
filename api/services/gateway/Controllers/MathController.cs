using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Grpc.Net.Client;
using gateway.Models;
using Protomath;

namespace gateway.Controllers
{
    [ApiController]
    public class MathController: ControllerBase
    {
        [HttpPost("math/add")]
        public async Task<double> Add(AddRequest req){
            AppContext.SetSwitch(
                "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var channel = GrpcChannel.ForAddress("http://localhost:8081");
            var client = new Protomath.mathService.mathServiceClient(channel);
            
            var addReq = new Protomath.addRequest();
            foreach(var num in req.numbers){
                addReq.Numbers.Add(num);
            }
            var reply = await client.addAsync(addReq);
            return reply.Result;
        }
        [HttpPost("math/divide")]
        public async Task<double> Divide(DivideRequest req){
            AppContext.SetSwitch(
                "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var channel = GrpcChannel.ForAddress("http://localhost:8081");
            var client = new Protomath.mathService.mathServiceClient(channel);

            var divideReq = new Protomath.divideRequest();
            foreach(var num in req.numbers){
                divideReq.Numbers.Add(num);
            }
            var reply = await client.divideAsync(divideReq);
            return reply.Result;
        }
        [HttpPost("math/average")]
        public async Task<double> Average(AddRequest req){
            AppContext.SetSwitch(
                "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var channel = GrpcChannel.ForAddress("http://localhost:8081");
            var client = new Protomath.mathService.mathServiceClient(channel);


            var addReq = new Protomath.addRequest();
            foreach(var num in req.numbers){
                addReq.Numbers.Add(num);
            }
            var addReply = await client.addAsync(addReq);
            var divideReq = new Protomath.divideRequest();
            divideReq.Numbers.Add(addReply.Result);
            divideReq.Numbers.Add(addReq.Numbers.Count);
            var divideReply = await client.divideAsync(divideReq);
            return divideReply.Result;
        }
        
    }
}