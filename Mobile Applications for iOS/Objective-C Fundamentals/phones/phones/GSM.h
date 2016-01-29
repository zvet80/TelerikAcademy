//
//  GSM.h
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Battery.h"
#import "Display.h"

@interface GSM : NSObject

@property (strong, nonatomic) NSString *model;

@property double price;

@property (strong, nonatomic) NSString* owner;

@property (strong, nonatomic) NSString* manufacturer;

@property (strong, nonatomic) Battery* battery;

@property (strong, nonatomic) Display* display;

-(instancetype) initWithModel: (NSString*) model
              andManufacturer: (NSString*) manufacturer;

-(instancetype) initWithModel: (NSString*) model
                 Manufacturer: (NSString*) manufacturer
                     andOwner: (NSString*) owner;

-(instancetype) initWithModel: (NSString*) model
                 Manufacturer: (NSString*) manufacturer
                     andPrice: (double) price;

-(instancetype) initWithModel: (NSString*) model
                 Manufacturer: (NSString*) manufacturer
                        Owner: (NSString*) owner
                        Price: (double) price
                      Battery: (Battery*) battery
                   andDisplay: (Display*) display;

+(GSM*) gsmWithModel: (NSString*) model
     andManufacturer: (NSString*) manufacturer;

+(GSM*) gsmWithModel: (NSString*) model
        Manufacturer: (NSString*) manufacturer
            andOwner: (NSString*) owner;

+(GSM*) gsmWithModel: (NSString*) model
        Manufacturer: (NSString*) manufacturer
            andPrice: (double) price;

+(GSM*) gsmWithModel: (NSString*) model
        Manufacturer: (NSString*) manufacturer
               Owner: (NSString*) owner
               Price: (double) price
             Battery: (Battery*) battery
          andDisplay: (Display*) display;

+(GSM*)IPhone5S;

@end
