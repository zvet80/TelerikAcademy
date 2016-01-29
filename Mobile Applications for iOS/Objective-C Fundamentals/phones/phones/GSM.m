//
//  GSM.m
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import "GSM.h"

@implementation GSM

@synthesize model = _model;
@synthesize manufacturer = _manufacturer;

-(void)setModel:(NSString *)model{
    if (model==nil) {
        [NSException raise:@"Ivalid model" format:@"Model is required"];
    }
    
    _model=model;
}

-(NSString*)model{
    return _model;
}

-(void)setManufacturer:(NSString *)manufacturer{
    if (manufacturer==nil) {
        [NSException raise:@"Ivalid manufacturer" format:@"Manufacturer is required"];
    }
    
    _manufacturer=manufacturer;
}

-(NSString*)manufacturer{
    return _manufacturer;
}

-(instancetype)initWithModel:(NSString *)model andManufacturer:(NSString *)manufacturer{
    return [self initWithModel:model Manufacturer:manufacturer Owner:nil Price:0 Battery:nil andDisplay:nil];
}

-(instancetype)initWithModel:(NSString *)model Manufacturer:(NSString *)manufacturer andOwner:(NSString *)owner{
    return [self initWithModel:model Manufacturer:manufacturer Owner:owner Price:0 Battery:nil andDisplay:nil];
}

-(instancetype)initWithModel:(NSString *)model Manufacturer:(NSString *)manufacturer andPrice:(double)price{
    return [self initWithModel:model Manufacturer:manufacturer Owner:nil Price:price Battery:nil andDisplay:nil];
}

-(instancetype)initWithModel:(NSString *)model Manufacturer:(NSString *)manufacturer Owner:(NSString *)owner Price:(double)price Battery:(Battery *)battery andDisplay:(Display *)display{
    self = [super init];
    if (self) {
        self.model = model;
        self.manufacturer=manufacturer;
        self.price=price;
        self.owner=owner;
        self.battery=battery;
        self.display=display;
    }

    return self;
}
              
+(GSM *)gsmWithModel:(NSString *)model andManufacturer:(NSString *)manufacturer{
    return [[GSM alloc] initWithModel:model andManufacturer:manufacturer];
}

+(GSM*)gsmWithModel:(NSString *)model Manufacturer:(NSString *)manufacturer andOwner:(NSString *)owner{
    return [[GSM alloc] initWithModel:model Manufacturer:manufacturer andOwner:owner];
}

+(GSM*)gsmWithModel:(NSString *)model Manufacturer:(NSString *)manufacturer andPrice:(double)price{
    return [[GSM alloc] initWithModel:model Manufacturer:manufacturer andPrice:price];
}

+(GSM*)gsmWithModel:(NSString *)model Manufacturer:(NSString *)manufacturer Owner:(NSString *)owner Price:(double)price Battery:(Battery *)battery andDisplay:(Display *)display{
    return [[GSM alloc] initWithModel:model Manufacturer:manufacturer Owner:owner Price:price Battery:battery andDisplay:display];
}

+(GSM*)IPhone5S{
    return [[GSM alloc] initWithModel:@"IPhone5S" andManufacturer:@"Apple"];
}

-(NSString *)description{
    return [NSString stringWithFormat:@"Model: %@, Manufacturer: %@, Owner: %@, price: %f, battery: %@, display: %@",
            self.model,
            self.manufacturer,
            self.owner,
            self.price,
            self.battery,
            self.display];
}

@end
