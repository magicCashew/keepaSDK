/*
 * Keepa API
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.prokarma.pkmst.controller;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.prokarma.pkmst.model.Category;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.http.ResponseEntity;
import org.springframework.web.multipart.MultipartFile;

/**
 * API tests for CategoryApi
 */
@Ignore
public class CategoryApiTest {

    private final ObjectMapper objectMapper = new ObjectMapper();

    private final CategoryApi api = new CategoryApiController(objectMapper);

    private final String accept = "application/json";

    
    /**
     * Returns Amazon category information from Keepa API.
     *
     * Retrieve category objects using their node ids and (optional) their parent tree.
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void categoryTest() throws Exception {
        String key = null;
        Integer domain = null;
        Integer category = null;
        Integer parents = null;
    ResponseEntity<List<Category>> response = api.category(key, domain, category, parents , accept);

        // TODO: test validations
    }
    
}
