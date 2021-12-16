using AspNETasmxWS.Commands.Contracts;
using AspNETasmxWS.Entities;
using AspNETasmxWS.Infra.DataAccess;
using AspNETasmxWS.Infra.Services;
using AspNETasmxWS.Responses;
using AspNETasmxWS.Responses.Contracts;
using System;
using System.Collections.Generic;

namespace AspNETasmxWS.Commands
{
    public class MediaInsertCommand : IMediaInsertCommand
    {
        private MediaDao mediaDao;
        private MediaService mediaService;

        public MediaInsertCommand() { 
            mediaDao = new MediaDao();
            mediaService = new MediaService(mediaDao);
        }

        public IResponse Execute(Requisition requisition){
            
            var response = new Response();
            var insertMedia = new MediaInsert();
            
            insertMedia.Protocol = Guid.NewGuid().ToString();
            insertMedia.HasBeingInserted = mediaService.SaveMedia(requisition);

            response.Processed = insertMedia.HasBeingInserted;
            response.HasErrors = !insertMedia.HasBeingInserted;
            response.ResponseList = new List<Object>();
            response.ResponseList.Add((Object) insertMedia);

            return response;
        }
    }
}