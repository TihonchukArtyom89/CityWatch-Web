//var map_center = [37.83, 47.99];
var map_center_rev = [47.99,37.83];
var geo_coord_request= [
    [47.9781,37.7847],
    [47.9856,37.8102],
    [48.0092,37.7959],
    [47.9746,37.7571],
    [48.0032,37.7749]
];
var geo_coord_point ;
// var map = new ol.Map({
//     target: 'map_OL',
//     layers: [
//         new ol.layer.Tile({
//             source: new ol.source.OSM()
//         })
//     ],
//     view: new ol.View({
//         center: ol.proj.fromLonLat(map_center),
//         zoom: 10
//     })
// });
ymaps.ready(init).catch(console.error);
function init() {
    var myMap = new ymaps.Map("map_yandex", {
        center: map_center_rev,
        zoom: 10
    });

    myMap.geoObjects
        .add(new ymaps.Placemark(geo_coord_request[0], {
            balloonContent: 'Заявка 1'
        }, {
            preset: 'islands#redIcon'
        }))
        .add(new ymaps.Placemark(geo_coord_request[1], {
            balloonContent: 'Заявка 2'
        }, {
            preset: 'islands#redIcon'
        }))
        .add(new ymaps.Placemark(geo_coord_request[2], {
            balloonContent: 'Заявка 3'
        }, {
            preset: 'islands#redIcon'
        }))
        .add(new ymaps.Placemark(geo_coord_request[3], {
            balloonContent: 'Заявка 4'
        }, {
            preset: 'islands#redIcon'
        }))
        .add(new ymaps.Placemark(geo_coord_request[4], {
            balloonContent: 'Заявка 5'
        }, {
            preset: 'islands#redIcon'
        }
        ));

        myMap.events.add('click', function (e) {
            geo_coord_point = e.get('coords');
            myMap.geoObjects
            .add(new ymaps.Placemark(geo_coord_point, {
                balloonContent: 'Новая заявка'
            }, {
                preset: 'islands#blueIcon'
            }
            ));
            $("#coord_text").text(geo_coord_point);
        });
}

        
