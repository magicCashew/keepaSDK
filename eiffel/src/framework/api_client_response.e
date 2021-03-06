note
 description:"[
		Keepa API
 		The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
  		OpenAPI spec version: 1.0.0
 	    Contact: info@keepa.com

  	NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).

 		 Do not edit the class manually.
 	]"
	date: "$Date$"
	revision: "$Revision$"
	EIS:"Eiffel openapi generator", "src=https://openapi-generator.tech", "protocol=uri"
class
	API_CLIENT_RESPONSE

create
	make

feature {NONE} -- Initialization

	make (a_response: detachable HTTP_CLIENT_RESPONSE; a_error: detachable API_ERROR; a_custom_deserializer: detachable FUNCTION [TUPLE [STRING, STRING, TYPE [detachable ANY]], detachable ANY])
		do
			response := a_response
			error := a_error
			deserializer := a_custom_deserializer
		end

feature -- Access

	has_error: BOOLEAN
			-- has error?
		do
			Result := response = Void and then attached error
		end

	status: INTEGER
		do
			if attached response as l_response then
				Result := l_response.status
			end
		end

feature -- Data

	data (a_type: TYPE [detachable ANY]): detachable ANY
			-- Data representation of the HTTP Response
		do
			if
				attached response as l_response  and then
				attached deserializer as l_deserializer and then
				attached l_response.body as l_body and then
				attached l_response.header ("Content-Type") as l_content_type
			then
				Result := (create {API_DESERIALIZER}).deserializer (l_deserializer, l_content_type, l_body, a_type)
			end
		end

feature -- Error

	error: detachable API_ERROR
			-- Internal client error.

feature {NONE} -- Implementation

	response: detachable HTTP_CLIENT_RESPONSE
			-- Low level response returned by the API call.

	deserializer: detachable FUNCTION [TUPLE [STRING, STRING, TYPE [detachable ANY]], detachable ANY]
			-- function to map a response body with a given content type to the target
			-- in the domain model.

end
