=begin comment

Keepa API

The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.

OpenAPI spec version: 1.0.0
Contact: info@keepa.com
Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator
# Please update the test cases below to test the API endpoints.
# Ref: https://openapi-generator.tech
#
use Test::More tests => 1; #TODO update number of test cases
use Test::Exception;

use lib 'lib';
use strict;
use warnings;

use_ok('WWW::OpenAPIClient::CategoryApi');

my $api = WWW::OpenAPIClient::CategoryApi->new();
isa_ok($api, 'WWW::OpenAPIClient::CategoryApi');

#
# category test
#
{
    my $key = undef; # replace NULL with a proper value
    my $domain = undef; # replace NULL with a proper value
    my $category = undef; # replace NULL with a proper value
    my $parents = undef; # replace NULL with a proper value
    my $result = $api->category(key => $key, domain => $domain, category => $category, parents => $parents);
}


1;
