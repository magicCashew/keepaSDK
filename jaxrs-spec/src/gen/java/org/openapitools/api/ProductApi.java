package org.openapitools.api;

import org.openapitools.model.Category;

import javax.ws.rs.*;
import javax.ws.rs.core.Response;

import io.swagger.annotations.*;

import java.io.InputStream;
import java.util.Map;
import java.util.List;
import javax.validation.constraints.*;
import javax.validation.Valid;

@Path("/product")
@Api(description = "the product API")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaJAXRSSpecServerCodegen", date = "2019-03-02T22:58:42.301Z[Etc/UTC]")
public class ProductApi {

    @GET
    @Produces({ "application/json" })
    @ApiOperation(value = "Retrieve the product for the specified ASIN and domain.", notes = "Retrieves the product object for the specified ASIN and domain. If our last update is older than one hour it will be automatically refreshed before delivered to you to ensure you get near to real-time pricing data.  You can request products via either their ASIN (preferred) or via UPC and EAN codes. You can not use both parameters, asin and code, in the same request. Keepa can not track Amazon Fresh and eBooks.", response = Category.class, responseContainer = "List", tags={ "product" })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "search results matching criteria", response = Category.class, responseContainer = "List"),
        @ApiResponse(code = 400, message = "bad input parameter", response = Void.class)
    })
    public Response product(@QueryParam("key") @NotNull   @ApiParam("Your private API key.")  String key,@QueryParam("domain") @NotNull   @ApiParam("Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)")  Integer domain,@QueryParam("asin")   @ApiParam("The ASIN of the product you want to request. For batch requests a comma separated list of ASINs (up to one hundred).")  String asin,@QueryParam("code")   @ApiParam("The product code of the product you want to request. We currently allow UPC, EAN and ISBN-13 codes. For batch requests a comma separated list of codes (up to one hundred). Multiple ASINs can have the same product code, so requesting a product code can return multiple products.")  String code) {
        return Response.ok().entity("magic!").build();
    }
}
